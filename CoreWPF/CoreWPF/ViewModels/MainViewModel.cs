using CoreWPF.Model;
using CoreWPF.UserControls;
using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Media;

namespace CoreWPF.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        public MainViewModel()
        {
            _categories = new List<Category>
            {
                new Category{CategoryName="School",ID=1,BackColor = (SolidColorBrush)(new BrushConverter().ConvertFrom("#001E36")),
                    TodoItems= new List<TodoItem>
                    {
                        new TodoItem { Title = "Do homework", Description = "Do your homework immediately", CreatedDate = DateTime.Now, },
                        new TodoItem {Title="Study English",Description="Study english for toefl exams",CreatedDate= DateTime.Now },
                    }
                },
                new Category{CategoryName="Home",ID=2,BackColor= (SolidColorBrush)(new BrushConverter().ConvertFrom("#00345E")),
                    TodoItems=new List<TodoItem>
                    {
                         new TodoItem {Title="Clean home",Description="Clean everypart of home",CreatedDate= DateTime.Now },
                    }
                },
                new Category{CategoryName="Custom",ID=3, BackColor= (SolidColorBrush)(new BrushConverter().ConvertFrom("#004B86")) ,
                    TodoItems =new List<TodoItem>
                    {
                new TodoItem {Title="Nothing",Description="Do nothing!",CreatedDate= DateTime.Now },
                    }
                },
            };
        }
   

        private List<Category> _categories;

        public List<Category> Categories
        {
            get { return _categories; }
            set
            {
                _categories = value;
                RaisePropertyChanged(() => Categories);
            }
        }


    }
}
