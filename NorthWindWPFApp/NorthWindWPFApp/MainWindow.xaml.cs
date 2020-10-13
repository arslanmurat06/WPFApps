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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace NorthWindWPFApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private MainViewModel viewModel;
        public MainWindow()
        {
            DataContextChanged += MainWindow_DataContextChanged;
            InitializeComponent();
        }

        private void MainWindow_DataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {

            viewModel = DataContext as MainViewModel;

            if(viewModel != null)
            {
                viewModel.GetPassword = new Func<string>(GetPassword);
            }

        }

        private void Border_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            viewModel.IsPasswordShow = !viewModel.IsPasswordShow;
            ChangePasswordBoxVisibility(viewModel.IsPasswordShow);
        }

        private void Border_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            viewModel.IsPasswordShow = !viewModel.IsPasswordShow;
            ChangePasswordBoxVisibility(viewModel.IsPasswordShow);
        }



        private void ChangePasswordBoxVisibility(bool isShow)
        {
            //if (isShow)
            //{
            //    pswTxt.Text = GetPassword();
            //    pswTxt.Visibility = Visibility.Visible;
            //    pswTxt.IsEnabled = false;
            //    txtPassword.Visibility = Visibility.Hidden;
            //}
            //else
            //{
            //    pswTxt.Visibility = Visibility.Hidden;
            //    txtPassword.Visibility = Visibility.Visible;
            //}
        }
        public string GetPassword()
        {
            return txtPassword.Password;
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                DragMove();

        }
    }
}
