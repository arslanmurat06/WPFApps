using CoreWPF.UserControls;
using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Media;
using System.Linq;
using CoreWPF.Models;
using CoreWPF.Model;
using Microsoft.EntityFrameworkCore;
using CoreWPF.Repository;
using System.Security.Cryptography.Xml;

namespace CoreWPF.ViewModels
{
    public class MainViewModel : ViewModelBase
    {

        IToDoRepository _repository;

        public MainViewModel(IToDoRepository repository)
        {

            _repository = repository;

            var a = _repository.GetToDoItems();

            using (ToDoContext context = new ToDoContext())
            {
                var b = context.TodoItems.ToList();
            }


            //_categories = new List<Category>
            //{
            //    new Category{CategoryName="School",ID=1,//(Brush)(new BrushConverter().ConvertFrom("#001E36")),
            //        TodoItems= new List<TodoItem>
            //        {
            //            new TodoItem {Title = "Do homework", Description = "Do your homework immediately", CreatedDate = DateTime.Now, },
            //            new TodoItem {Title = "Do homework", Description = "Do your homework immediately", CreatedDate = DateTime.Now, },
            //            new TodoItem {Title = "Do homework", Description = "Do your homework immediately", CreatedDate = DateTime.Now, },
            //            new TodoItem {Title="Study English",Description="Study english for toefl exams",CreatedDate= DateTime.Now },
            //            new TodoItem {Title="Study English",Description="Study english for toefl exams",CreatedDate= DateTime.Now },
            //            new TodoItem {Title="Study English",Description="Study english for toefl exams",CreatedDate= DateTime.Now },
            //            new TodoItem {Title="Study English",Description="Study english for toefl exams",CreatedDate= DateTime.Now },
            //            new TodoItem {Title="Study English",Description="Study english for toefl exams",CreatedDate= DateTime.Now },
            //        },BackColor = "#001E36",
            //    },
            //    new Category{CategoryName="Home",ID=2, //(Brush)(new BrushConverter().ConvertFrom("#00345E")),
            //        TodoItems=new List<TodoItem>
            //        {
            //             new TodoItem {Title="Clean home",Description="Clean everypart of home",CreatedDate= DateTime.Now },
            //             new TodoItem {Title="Clean home",Description="Clean everypart of home",CreatedDate= DateTime.Now },
            //             new TodoItem {Title="Clean home",Description="Clean everypart of home",CreatedDate= DateTime.Now },
            //             new TodoItem {Title="Clean home",Description="Clean everypart of home",CreatedDate= DateTime.Now },
            //             new TodoItem {Title="Clean home",Description="Clean everypart of home",CreatedDate= DateTime.Now },
            //             new TodoItem {Title="Clean home",Description="Clean everypart of home",CreatedDate= DateTime.Now },
            //             new TodoItem {Title="Clean home",Description="Clean everypart of home",CreatedDate= DateTime.Now },
            //        },BackColor="#00345E"
            //    },
            //    new Category{CategoryName="Custom",ID=3, //(Brush)(new BrushConverter().ConvertFrom("#004B86")) ,
            //        TodoItems =new List<TodoItem>
            //        {
            //    new TodoItem {Title="Nothing",Description="Do nothing!",CreatedDate= DateTime.Now },
            //    new TodoItem {Title="Nothing",Description="Do nothing!",CreatedDate= DateTime.Now },
            //    new TodoItem {Title="Nothing",Description="Do nothing!",CreatedDate= DateTime.Now },
            //    new TodoItem {Title="Nothing",Description="Do nothing!",CreatedDate= DateTime.Now },
            //    new TodoItem {Title="Nothing",Description="Do nothing!",CreatedDate= DateTime.Now },
            //    new TodoItem {Title="Nothing",Description="Do nothing!",CreatedDate= DateTime.Now },
            //        }, BackColor="#004B86"
            //    },
            //};
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
