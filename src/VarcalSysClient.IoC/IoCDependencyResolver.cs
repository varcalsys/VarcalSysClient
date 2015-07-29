﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace VarcalSysClient.IoC
{
    public class IoCDependencyResolver: IDependencyResolver
    {
        public object GetService(Type serviceType)
        {
            return IocStartup.Get(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return IocStartup.GetAll(serviceType);
        }
    }
}
