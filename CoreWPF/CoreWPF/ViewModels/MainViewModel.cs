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
using System.Windows.Input;
using GalaSoft.MvvmLight.Command;
using System.Security.Cryptography.X509Certificates;
using GalaSoft.MvvmLight.Messaging;
using CoreWPF.Messages;

namespace CoreWPF.ViewModels
{
    public class MainViewModel : ViewModelBase
    {

        IToDoRepository _repository;
        public  ICommand SaveCategoryCommand { get; set; }
        public  ICommand SaveTodoItemCommand { get; set; }

        public ICommand OpenTodoItem { get; set; }

        public Action CloseSaveCategoryAction { get; set; }
        public MainViewModel(IToDoRepository repository)
        {
            Messenger.Default.Register<EditTodoItemMessage>(this, OnEditTodoItemMessageReceived);
            SaveCategoryCommand = new RelayCommand(SaveCategory);
            SaveTodoItemCommand = new RelayCommand(SaveTodo);
            _repository = repository;
            _categories = _repository.GetCategories();

        }

        private void OnEditTodoItemMessageReceived(EditTodoItemMessage obj)
        {
            var todoItem = obj.TodoItem;
            SavedTodoTitle = todoItem.Title;
            SavedTodoDescription = todoItem.Description;
            SelectedCategory = todoItem.Category;
            DialogTitle = "Edit TodoItem";
            MaterialDesignThemes.Wpf.DialogHost.OpenDialogCommand.Execute(null, null);
        }

        private string _dialogTitle ="Create TodoItem";

        public string DialogTitle
        {
            get { return _dialogTitle;}
            set 
            {
                _dialogTitle = value;
                RaisePropertyChanged(()=> DialogTitle);
            }
        }


        private Category _selectedCategory;
        public Category SelectedCategory
        {
            get { return _selectedCategory; }
            set 
            {
                _selectedCategory = value;
                RaisePropertyChanged(()=> SelectedCategory);
            }
        }

        private string _savedTodoTitle;

        public string SavedTodoTitle
        {
            get { return _savedTodoTitle; }
            set 
            {
                _savedTodoTitle = value;
                RaisePropertyChanged(() => SavedTodoTitle);
            }
        }



        private string _savedTodoDescription;

        public string SavedTodoDescription
        {
            get { return _savedTodoDescription; }
            set
            {
                _savedTodoDescription = value;
                RaisePropertyChanged(() => SavedTodoDescription);
            }
        }


        public TodoItem SavedTodoItem
        {
            get 
            {

                if (!String.IsNullOrEmpty(SavedTodoTitle) && !String.IsNullOrEmpty(SavedTodoDescription) && SelectedCategory !=null)
                    return new TodoItem {Title = SavedTodoTitle,Description = SavedTodoDescription, Category= SelectedCategory };
                else
                    return null;
            }
        }


        public Category SavedCategory
        {
            get 
            {
                if (!String.IsNullOrEmpty(SavedCategoryName) && !String.IsNullOrEmpty(SavedCategoryColor))
                    return new Category { CategoryName = SavedCategoryName, BackColor = SavedCategoryColor };
                else
                    return null;
            }
         
        }

        private string _savedCategoryName;

        public string SavedCategoryName
        {
            get { return _savedCategoryName; }
            set 
            { 
                _savedCategoryName = value;
                RaisePropertyChanged(()=> SavedCategoryName);
            }
        }

        private string _savedCategoryColor;

        public string SavedCategoryColor
        {
            get { return _savedCategoryColor; }
            set 
            { 
                _savedCategoryColor = value;
                RaisePropertyChanged(() => SavedCategoryColor);
            }
        }


        private void SaveTodo()
        {
            if(SavedTodoItem != null)
            {
                _repository.Save(new List<IBaseModel> { SavedTodoItem });
                _categories = _repository.GetCategories();
                RaisePropertyChanged(() => Categories);
                SavedTodoDescription = "";
                SavedTodoTitle = "";
                SelectedCategory = null;

                CloseSaveCategoryAction?.Invoke();
            }
        }


        private void SaveCategory()
        {
            if (SavedCategory != null)
            {
                var savedCat = _repository.Save(new List<IBaseModel> { SavedCategory }).First();
                _categories.Add(savedCat);
                RaisePropertyChanged(() => Categories);
                SavedCategoryName = "";
                SavedCategoryColor = "";
                CloseSaveCategoryAction?.Invoke();
            }
        }

        private List<IBaseModel> _categories;

        public List<IBaseModel> Categories
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

