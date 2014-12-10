using Castle.Windsor;
using Castle.Windsor.Installer;
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

        public static IWindsorContainer BootstrapContainer()
        {
            container = new WindsorContainer()
                .Install(FromAssembly.This());
            
            var controllerFactory = new WindsorControllerFactory(container.Kernel);
            System.Web.Mvc.ControllerBuilder.Current.SetControllerFactory(controllerFactory);

            return container;
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