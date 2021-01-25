using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using SCGraphQL.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SCGraphQL.IoCManagement
{
    public class DependecyInstaller : IWindsorInstaller
    {
        public const string _mask = "SCGraphQL.*";
        public static string _assemblyDirectoryName { get; } = string.Empty;
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            AssemblyFilter assemblyFilter = new AssemblyFilter(_assemblyDirectoryName, mask: _mask);
            container.Register(Classes.FromAssemblyInDirectory(assemblyFilter).BasedOn<IScoppedDependency>()
                     .WithServiceSelect(ServiceSelector).LifestyleScoped()
                     );
        }
        private static IEnumerable<Type> ServiceSelector(Type type, Type[] baseTypes)
        {
            var result = type.GetInterfaces().ToList();

            result.Add(type);
            return result;
        }
    }
}
