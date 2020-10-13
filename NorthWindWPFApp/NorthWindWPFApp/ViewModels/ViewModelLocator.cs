using CommonServiceLocator;
using GalaSoft.MvvmLight.Ioc;
using NorthWindApp.DBLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWindWPFApp.ViewModels
{
    public class ViewModelLocator
    {
        static ViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);
            SimpleIoc.Default.Register<MainViewModel>();
            SimpleIoc.Default.Register<EmployeeOverviewViewModel>();
            SimpleIoc.Default.Register<INorthWindRepository, NorthWindRepository>();
        }

        public MainViewModel MainViewModel
        {
            get
            {
                return ServiceLocator.Current.GetInstance<MainViewModel>();
            }
        }

        public EmployeeOverviewViewModel EmployeeOverviewViewModel
        {
            get
            {
                return ServiceLocator.Current.GetInstance<EmployeeOverviewViewModel>();
            }
        }
    }
}
