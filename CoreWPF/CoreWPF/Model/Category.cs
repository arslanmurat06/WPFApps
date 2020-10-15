using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Media;

namespace CoreWPF.Model
{
    public class Category:ViewModelBase
    {
        public int ID { get; set; }
        public string CategoryName { get; set; }
        public List<TodoItem> TodoItems { get; set; }
        

        private string _backColor;
        public string BackColor
        {
            get => _backColor;
            set
            {
                _backColor = value;
                if (TodoItems == null)
                    return;
                foreach (var item in TodoItems)
                {
                    item.BackColor = _backColor;
                    RaisePropertyChanged(()=> BackColor);
                    
                }
            }
        }
    }
}
