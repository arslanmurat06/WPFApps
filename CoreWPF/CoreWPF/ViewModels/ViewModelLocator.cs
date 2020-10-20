using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;


namespace CoreWPF.ViewModels
{
    public class ViewModelLocator
    {
        public MainViewModel MainViewModel
         => App.ServiceProvider.GetRequiredService<MainViewModel>();

    }
}
