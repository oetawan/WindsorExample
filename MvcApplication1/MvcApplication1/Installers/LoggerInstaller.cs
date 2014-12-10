using Castle.DynamicProxy;
using Castle.Facilities.Logging;
using Castle.MicroKernel.Registration;
using MvcApplication1.Interceptors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication1.Installers
{
    public class LoggerInstaller: IWindsorInstaller
    {
        public void Install(Castle.Windsor.IWindsorContainer container, Castle.MicroKernel.SubSystems.Configuration.IConfigurationStore store)
        {
            container.AddFacility<LoggingFacility>(f => f.UseLog4Net());
            container.Register(
                Component.
                For<IInterceptor>().
                ImplementedBy<LogInterceptor>().
                Named("LogInterceptor"));
        }
    }
}