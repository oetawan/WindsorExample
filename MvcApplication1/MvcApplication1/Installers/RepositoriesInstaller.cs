using Castle.Core;
using Castle.MicroKernel.Registration;
using MvcApplication1.Interceptors;
using OdeToFood.Data.Contract;
using OdeToFood.Data.SqlRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication1.Installers
{
    public class RepositoriesInstaller : IWindsorInstaller
    {
        public void Install(Castle.Windsor.IWindsorContainer container, Castle.MicroKernel.SubSystems.Configuration.IConfigurationStore store)
        {
            container.Register(
                Component.
                For<IRestaurantRepository>().
                ImplementedBy<RestaurantRepository>().
                LifestyleTransient().
                Interceptors(InterceptorReference.ForKey("LogInterceptor")).Anywhere);
        }
    }
}