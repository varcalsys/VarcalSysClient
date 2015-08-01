using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject.Modules;
using VarcalSysClient.Data.AppDbContext;
using VarcalSysClient.Data.Repositories;
using VarcalSysClient.Data.Repositories.Core;
using VarcalSysClient.Domain.Contracts.Repositories;
using VarcalSysClient.Domain.Contracts.Repositories.Core;
using VarcalSysClient.Domain.Contracts.Services;
using VarcalSysClient.Domain.Contracts.Services.Core;
using VarcalSysClient.Domain.Entities;
using VarcalSysClient.Domain.Enums;
using VarcalSysClient.Domain.Services;

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

            //Services
            //Repositories
            Bind(typeof(IBaseDomainService<>)).To(typeof(IBaseDomainService<>));
            Bind<ICidadeDomainService>().To<ICidadeDomainService>();
            Bind<IClienteDomainService>().To<ClienteDomainService>();
            Bind<IContatoDomainService>().To<ContatoDomainService>();
            Bind<IEmpresaDomainService>().To<EmpresaDomainService>();
            Bind<IEnderecoDomainService>().To<EnderecoDomainService>();
            Bind<IEstadoDomainService>().To<EstadoDomainService>();
            Bind<IMensagemDomainService>().To<MensagemDomainService>();
            Bind<PessoaDomainService>().To<PessoaDomainService>();
            Bind<IPessoaFisicaDomainService>().To<PessoaFisicaDomainService>();
            Bind<IPessoaJuridicaDomainService>().To<PessoaJuridicaDomainService>();
            Bind<IPlanoHostDomainService>().To<PlanoHostDomainService>();
            Bind<ITicketDomainService>().To<TicketDomainService>();
            Bind<ITicketTipoDomainService>().To<TicketTipoDomainService>();
        }
    }
}
