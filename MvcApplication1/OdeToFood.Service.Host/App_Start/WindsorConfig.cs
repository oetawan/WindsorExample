using Castle.Windsor;
using Castle.Windsor.Installer;
using Microsoft.Practices.ServiceLocation;
using Microsoft.Practices.Windsor.ServiceLocatorAdapter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OdeToFood.Service.Host.App_Start
{
    public static class WindsorConfig
    {
        public static void Configure()
        {
            WindsorContainer container = new WindsorContainer();
            container.Install(FromAssembly.This());

            WindsorServiceLocator windsorServiceLocator = new WindsorServiceLocator(container);
            ServiceLocator.SetLocatorProvider(() => windsorServiceLocator);
        }
    }
}