using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using NorthWindApp.DBLayer;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace NorthWindWPFApp.ViewModels
{
    public class MainViewModel: ViewModelBase
    {
        #region COMMANDS

        INorthWindRepository _repository;

        public ICommand LoginCommand { get; private set; }

        public Action CloseScreen;
        #endregion

        public Func<string> GetPassword { get; set; }

        public MainViewModel(INorthWindRepository repository)
        {
            LoginCommand = new RelayCommand(LoginAsync);
            _repository = repository;
        }

        private void LoginAsync()
        {
            var employeeScreen = new EmployeeOverview();
            employeeScreen.Show();
            CloseScreen?.Invoke();

        }

        private string _username;

        public string Username
        {
            get { return _username; }
            set 
            { 
                if(value != _username)
                {
                    _username = value;
                    RaisePropertyChanged(() => Username);
                }
                   
            }
        }

        public string Password
        {
            get { return GetPassword(); }

        }

        private bool _isPasswordShow = false;

        public bool IsPasswordShow
        {
            get { return _isPasswordShow; }
            set
            {
                _isPasswordShow = value;
                RaisePropertyChanged(() => IsPasswordShow);
            }
        }
    }
}
