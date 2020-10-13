using GalaSoft.MvvmLight;
using NorthWindApp.DBLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWindWPFApp.ViewModels
{
    public class EmployeeOverviewViewModel:ViewModelBase
    {
        INorthWindRepository _repository;
        public EmployeeOverviewViewModel(INorthWindRepository repository)
        {
            _repository = repository;
            _employees = _repository.GetEmployees();
        }
        private List<Employee> _employees;

        public List<Employee> Employees
        {
            get { return _employees; }
            set 
            { 
                _employees = value;
                RaisePropertyChanged(()=>Employees);
            }
        }

    }
}
