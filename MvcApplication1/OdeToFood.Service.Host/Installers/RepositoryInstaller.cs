using Castle.MicroKernel.Registration;
using OdeToFood.Data.Contract;
using OdeToFood.Data.SqlRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OdeToFood.Service.Host.Installers
{
    public class RepositoryInstaller : Castle.MicroKernel.Registration.IWindsorInstaller
    {
        public void Install(Castle.Windsor.IWindsorContainer container, Castle.MicroKernel.SubSystems.Configuration.IConfigurationStore store)
        {
            container.Register(
                Component.
                For<IRestaurantRepository>().
                ImplementedBy<RestaurantRepository>().
                LifestyleTransient());
        }
    }
}