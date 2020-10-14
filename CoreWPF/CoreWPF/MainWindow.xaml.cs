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

namespace CoreWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        bool IsWindowsMaximized = false;
        public MainWindow()
        {
            InitializeComponent();
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
    }
}
