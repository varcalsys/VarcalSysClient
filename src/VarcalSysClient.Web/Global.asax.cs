using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using VarcalSysClient.IoC.SimpleInjector;

namespace VarcalSysClient.Web
{
    public class MvcApplication : HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundle(BundleTable.Bundles);

            //IocStartup.Init();
            //DependencyResolver.SetResolver(new IoCDependencyResolver());

            DependencyResolver.SetResolver(IoCSimpleInjector.SimpleInjectorInit());
        }
    }
}
