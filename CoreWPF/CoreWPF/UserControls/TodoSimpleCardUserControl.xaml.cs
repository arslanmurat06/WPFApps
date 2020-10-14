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
        public TodoSimpleCardUserControl()
        {
            InitializeComponent();
            //ItemBorder.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom(MyColor));  
        }

        public static readonly DependencyProperty MyColorProperty =DependencyProperty.Register("Color", typeof(Brush), typeof(TodoSimpleCardUserControl));
        public string Color
        {
            get
            {
                return this.GetValue(MyColorProperty) as string;
            }
            set
            {
                this.SetValue(MyColorProperty, value);
            }
        }
    }
}
