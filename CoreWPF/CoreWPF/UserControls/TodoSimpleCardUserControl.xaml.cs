using CoreWPF.Messages;
using CoreWPF.Model;
using GalaSoft.MvvmLight.Messaging;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CoreWPF.UserControls
{
    /// <summary>
    /// Interaction logic for TodoSimpleCardUserControl.xaml
    /// </summary>
    public partial class TodoSimpleCardUserControl : UserControl
    {
        TodoItem item;
        public TodoSimpleCardUserControl()
        {
            DataContextChanged += TodoSimpleCardUserControl_DataContextChanged;
            InitializeComponent();
        }

        private void TodoSimpleCardUserControl_DataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            item = DataContext as TodoItem;
        }

        private void Border_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            //MaterialDesignThemes.Wpf.DialogHost.OpenDialogCommand.Execute(null, null);
            Messenger.Default.Send<EditTodoItemMessage>(new EditTodoItemMessage(item ));
        }
    }
}
