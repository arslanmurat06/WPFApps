using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Media;

namespace CoreWPF.Model
{
    public class Category
    {
        public int ID { get; set; }
        public string CategoryName { get; set; }
        public List<TodoItem> TodoItems { get; set; }
        public SolidColorBrush BackColor { get; set; }
    }
}
