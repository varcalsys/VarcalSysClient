using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using Ninject = VarcalSysCliente.IoC;

namespace VarcalSysCliente.Web
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            Ninject.IoC.Init();
            DependencyResolver.SetResolver(new Ninject.IoCDependencyResolver());
        }
    }
}
