using MaterialDesignThemes.Wpf;
using NorthWindWPFApp.Helper;
using NorthWindWPFApp.UserControls;
using NorthWindWPFApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace NorthWindWPFApp
{
    /// <summary>
    /// Interaction logic for EmployeeOverview.xaml
    /// </summary>
    public partial class OverViewScreen : Window
    {
        bool IsWindowsMaximized = false;
        private OverviewViewScreenViewModel viewModel;
        public OverViewScreen()
        {
            DataContextChanged += EmployeeOverview_DataContextChanged;
            InitializeComponent();
        }

        private void EmployeeOverview_DataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            viewModel = DataContext as OverviewViewScreenViewModel;
        }

        private void GridBar_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void Close_Button_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Minimize_Button_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;

        }

        private void Maximize_Button_Click(object sender, RoutedEventArgs e)
        {
            if (IsWindowsMaximized)
                this.WindowState = WindowState.Normal;
              
            else
                this.WindowState = WindowState.Maximized;

            IsWindowsMaximized = !IsWindowsMaximized;
        }

        private void Show_Customer_Click(object sender, RoutedEventArgs e)
        {
            this.PartGrid.Children.Clear();
            var customerView = new DataGridUserControl();
            customerView.DataGridTitle.Text = StaticStrings.CUSTOMER_LIST_TITLE;
            customerView.DataContext = viewModel.Customers;
            this.PartGrid.Children.Add(customerView);
        }

        private void Show_Employee_Click(object sender, RoutedEventArgs e)
        {
            this.PartGrid.Children.Clear();
            var emp = new EmployeeOverviewUserControl();
            emp.DataContext = viewModel.Employees;
            this.PartGrid.Children.Add(emp);
        }

        private void Show_Orders_Click(object sender, RoutedEventArgs e)
        {
            this.PartGrid.Children.Clear();
            var orderView = new DataGridUserControl();
            orderView.DataGridTitle.Text = StaticStrings.ORDER_LIST_TITLE;
            orderView.DataContext = viewModel.Orders;
            this.PartGrid.Children.Add(orderView);
        }
    }
}
