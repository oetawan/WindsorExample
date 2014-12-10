using Castle.Windsor;
using Microsoft.Practices.ServiceLocation;
using Microsoft.Practices.Windsor.ServiceLocatorAdapter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication1
{
    public static class ServiceLocatorConfig
    {
        public static void Configure(IWindsorContainer container)
        {
            WindsorServiceLocator windsorServiceLocator = new WindsorServiceLocator(container);
            ServiceLocator.SetLocatorProvider(() => windsorServiceLocator);
        }
    }
}