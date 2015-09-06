using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using CommonServiceLocator.NinjectAdapter.Unofficial;
using Microsoft.Practices.ServiceLocation;
using Ninject;

namespace VarcalSysCliente.IoC
{
    public class IoC
    {
        private static StandardKernel _kernel;

        public static void Init()
        {
            _kernel = new StandardKernel(new IoCModule());
            ServiceLocator.SetLocatorProvider(()=> new NinjectServiceLocator(_kernel));
        }


        public static object Get(Type type)
        {
            return _kernel.TryGet(type);
        }

        public static IEnumerable<object> GetAll(Type type)
        {
            return _kernel.GetAll(type);
        }
    }
}
