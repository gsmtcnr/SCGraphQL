using Castle.MicroKernel.Lifestyle;
using Castle.MicroKernel.Registration;
using Castle.Windsor;
using System;

namespace SCGraphQL.IoCManagement
{
    public static class IoCManager
    {
        private static WindsorContainer container;
        public static void Install()
        {
            if (container != null && IsInstalled)
            {
                return;
            }
            container = new WindsorContainer();
            container.Register(Classes.FromAssemblyInDirectory(new AssemblyFilter(DependecyInstaller._assemblyDirectoryName, mask: DependecyInstaller._mask))
                    .BasedOn<IWindsorInstaller>()
                    .WithServiceBase()
                    .LifestyleTransient());
            foreach (var item in container.ResolveAll<IWindsorInstaller>())
            {
                container.Install(item);

            }

            IsInstalled = true;
        }
        #region Static Methods
        public static bool IsInstalled { get; set; }
        public static T Resolve<T>()
        {
            using (BeginScope())
            {
                return container.Resolve<T>();
            }
        }
        public static void Register<T>(T component)
        {
            container.Register(Component.For(typeof(T)).Instance(component).LifestyleTransient());
        }
        public static IDisposable BeginScope()
        {
            return container.BeginScope();
        }
        public static object Resolve(Type service)
        {
            return container.Resolve(service);
        }
        public static void Disposed()
        {
            container.Dispose();
        }

        public static T[] ResolveAll<T>()
        {
            using (BeginScope())
            {
                return container.ResolveAll<T>();
            }
        }

        public static void Release(object instance)
        {
            container.Release(instance);
        }

        #endregion
    }
}
