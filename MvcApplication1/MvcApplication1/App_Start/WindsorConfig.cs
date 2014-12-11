using Castle.Windsor;
using Castle.Windsor.Installer;
using Microsoft.Practices.ServiceLocation;
using Microsoft.Practices.Windsor.ServiceLocatorAdapter;
using MvcApplication1.Plumbing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication1
{
    public static class WindsorConfig
    {
        private static IWindsorContainer container;

        public static void BootstrapContainer()
        {
            container = new WindsorContainer()
                .Install(FromAssembly.This());

            WindsorServiceLocator windsorServiceLocator = new WindsorServiceLocator(container);
            ServiceLocator.SetLocatorProvider(() => windsorServiceLocator);
            
            var controllerFactory = new WindsorControllerFactory(container.Kernel);
            System.Web.Mvc.ControllerBuilder.Current.SetControllerFactory(controllerFactory);
        }

        public static void DisposeContainer()
        {
            if (container != null)
            {
                container.Dispose();
            }
        }
    }
}