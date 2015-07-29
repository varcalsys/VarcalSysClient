using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject.Modules;
using VarcalSysClient.Data.Repositories.Base;
using VarcalSysClient.Domain.Contracts.Repositories.Base;

namespace VarcalSysClient.IoC
{
    public class IoCModule: NinjectModule
    {
        public override void Load()
        {
            Bind(typeof (IBaseRepository<>)).To(typeof (BaseRepository<>));
        }
    }
}
