﻿using AutoMapper;
using Caliburn.Micro;
using SRMDesktopUI.Helpers;
using SRMDesktopUI.Library.API;
using SRMDesktopUI.Library.Helpers;
using SRMDesktopUI.Library.Models;
using SRMDesktopUI.Models;
using SRMDesktopUI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace SRMDesktopUI
{
    public class Bootstrapper : BootstrapperBase
    {
        private readonly SimpleContainer _container = new SimpleContainer();

        public Bootstrapper()
        {
            Initialize();

            ConventionManager.AddElementConvention<PasswordBox>(
           PasswordBoxHelper.BoundPasswordProperty,
           "Password",
           "PasswordChanged");
        }

        private IMapper ConfigureAutoMapper()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<ProductModel, ProductDisplayModel>();
                cfg.CreateMap<CartItemModel, CartItemDisplayModel>();
            });

            var output = config.CreateMapper();

            return output;
        }

        protected override void Configure()
        {
            _container.Instance(ConfigureAutoMapper());

            _container.Instance(_container)
                    .PerRequest<IProductEndPoint, ProductEndPoint>()
                    .PerRequest<ISaleEndPoint, SaleEndPoint>();

            _container
                .Singleton<IWindowManager, WindowManager>()
                .Singleton<IEventAggregator, EventAggregator>()
                .Singleton<ILoggedInUserModel, LoggedInUserModel>()
                .Singleton<IApiHelper, ApiHelper>()
                .Singleton<IConfigHelper, ConfigHelper>();

            GetType().Assembly.GetTypes()
                .Where(type => type.IsClass)
                .Where(type => type.Name.EndsWith("ViewModel"))
                .ToList()
                .ForEach(viewModelType => _container.RegisterPerRequest(
                    viewModelType, viewModelType.ToString(), viewModelType));
        }
        protected override void OnStartup(object sender, StartupEventArgs e)
        {
            DisplayRootViewFor<ShellViewModel>();
        }

        protected override object GetInstance(Type service, string key)
            => _container.GetInstance(service, key);

        protected override IEnumerable<object> GetAllInstances(Type service)
            => _container.GetAllInstances(service);

        protected override void BuildUp(object instance)
        {
            _container.BuildUp(instance);
        }
    }
}
