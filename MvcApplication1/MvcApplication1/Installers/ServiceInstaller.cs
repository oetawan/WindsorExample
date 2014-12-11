using Castle.MicroKernel.Registration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace MvcApplication1.Installers
{
    public class ServiceInstaller : IWindsorInstaller
    {
        public void Install(Castle.Windsor.IWindsorContainer container, Castle.MicroKernel.SubSystems.Configuration.IConfigurationStore store)
        {
            AssemblyFilter filter = new AssemblyFilter(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "bin"));
            container.Register(
                AllTypes.
                FromAssemblyInDirectory(filter).
                Where(c => c.IsClass && c.Name.Contains("ServiceClient")).
                WithService.AllInterfaces().
                LifestyleTransient());
        }
    }
}