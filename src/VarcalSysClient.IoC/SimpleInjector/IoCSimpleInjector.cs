using System.Reflection;
using SimpleInjector;
using SimpleInjector.Integration.Web.Mvc;

namespace VarcalSysClient.IoC.SimpleInjector
{
    public class IoCSimpleInjector
    {
        static Container container;

        public static SimpleInjectorDependencyResolver SimpleInjectorInit()
        {
            container = new Container();

            container = IoCSimpleInjectorModule.Load(container);
            container.RegisterMvcControllers(Assembly.GetExecutingAssembly());
            container.RegisterMvcIntegratedFilterProvider();

            container.Verify();

            return new SimpleInjectorDependencyResolver(container);
        }
    }
}
