using GalaSoft.MvvmLight;
using NorthWindApp.DBLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWindWPFApp.ViewModels
{
    public class OverviewViewScreenViewModel:ViewModelBase
    {
        INorthWindRepository _repository;
        public OverviewViewScreenViewModel(INorthWindRepository repository)
        {
            _repository = repository;
            _employees = _repository.GetEmployees();
            _customers = _repository.GetCustomers();
            _orders = _repository.GetOrders();

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


        private List<Customer> _customers;

        public List<Customer> Customers
        {
            get { return _customers; }
            set
            {
                _customers = value;
                RaisePropertyChanged(() => Customers);
            }
        }

        private List<Order> _orders;

        public List<Order> Orders
        {
            get { return _orders; }
            set
            {
                _orders = value;
                RaisePropertyChanged(() => Orders);
            }
        }

    }
}
