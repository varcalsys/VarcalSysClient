using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject.Modules;
using VarcalSysClient.Data.AppDbContext;
using VarcalSysClient.Data.Repositories;
using VarcalSysClient.Data.Repositories.Base;
using VarcalSysClient.Domain.Contracts.Repositories;
using VarcalSysClient.Domain.Contracts.Repositories.Base;
using VarcalSysClient.Domain.Entities;

namespace VarcalSysClient.IoC
{
    public class IoCModule: NinjectModule
    {
        public override void Load()
        {
            //Repositories
            Bind<EfContext>().To<EfContext>();
            Bind(typeof (IBaseRepository<>)).To(typeof (BaseRepository<>));
            Bind<ICidadeRepository>().To<CidadeRepository>();
            Bind<IClienteRepository>().To<ClienteRepository>();
            Bind<IContatoRepository>().To<ContatoRepository>();
            Bind<IEmpresaRepository>().To<EmpresaRepository>();
            Bind<IEnderecoRepository>().To<EnderecoRepository>();
            Bind<IEstadoRepository>().To<EstadoRepository>();
            Bind<IMensagemRepository>().To<MensagemRepository>();
            Bind<PessoaRepository>().To<PessoaRepository>();
            Bind<IPessoaFisicaRepository>().To<PessoaFisicaRepository>();
            Bind<IPessoaJuridicaRepository>().To<PessoaJuridicaRepository>();
            Bind<IPlanoHostRepository>().To<PlanosHostRepository>();
            Bind<ITicketRepository>().To<TicketRepository>();
            Bind<ITicketTipoRepository>().To<TicketTipoRepository>();
        }
    }
}
