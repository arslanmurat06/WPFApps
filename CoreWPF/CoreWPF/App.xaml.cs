using AutoMapper;
using CoreWPF.MapperProfile;
using CoreWPF.Model;
using CoreWPF.Models;
using CoreWPF.Repository;
using CoreWPF.ViewModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;


namespace CoreWPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private readonly IHost host;
        public static IServiceProvider ServiceProvider { get; private set; }


        public App()
        {
            host = Host.CreateDefaultBuilder()
                .ConfigureAppConfiguration((context, builder) =>
                {
                    builder.AddJsonFile("appsettings.local.json", optional: true);
                }).ConfigureServices((context, services) =>
                {
                    ConfigureServices(context.Configuration, services);
                })
                .Build();

            ServiceProvider = host.Services;

        }

        

        private void ConfigureServices(IConfiguration configuration,
        IServiceCollection services)
        {
           
            
            services.AddScoped<IToDoRepository, ToDoRepository>();
            services.AddSingleton<MainViewModel>();

            // Register all the Windows of the applications.
            services.AddTransient<MainWindow>();

            services.AddAutoMapper(typeof(AutoMapperProfile));
        }

        protected override async void OnStartup(StartupEventArgs e)
        {
            await host.StartAsync();
            //var window = ServiceProvider.GetRequiredService<MainWindow>();
            //window.Show();

            base.OnStartup(e);
        }

        protected override async void OnExit(ExitEventArgs e)
        {
            // Original code...
        }
    }
}
