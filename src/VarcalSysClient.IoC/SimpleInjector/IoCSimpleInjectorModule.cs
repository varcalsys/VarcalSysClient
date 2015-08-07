using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleInjector;
using SimpleInjector.Extensions;
using VarcalSysClient.Data.AppDbContext;
using VarcalSysClient.Data.Repositories;
using VarcalSysClient.Data.Repositories.Core;
using VarcalSysClient.Domain.Contracts.Repositories;
using VarcalSysClient.Domain.Contracts.Repositories.Core;
using VarcalSysClient.Domain.Contracts.Services;
using VarcalSysClient.Domain.Contracts.Services.Core;
using VarcalSysClient.Domain.Services;
using VarcalSysClient.Domain.Services.Core;

namespace VarcalSysClient.IoC.SimpleInjector
{
    public class IoCSimpleInjectorModule
    {
        public static Container Load(Container container)
        {

            //Repositories
            container.Register<EfContext, EfContext>();
            container.RegisterOpenGeneric(typeof(IBaseRepository<>),typeof(BaseRepository<>));
            container.Register<ICidadeRepository,CidadeRepository>();
            container.Register<IClienteRepository,ClienteRepository>();
            container.Register<IContatoRepository,ContatoRepository>();
            container.Register<IEmpresaRepository,EmpresaRepository>();
            container.Register<IEnderecoRepository,EnderecoRepository>();
            container.Register<IEstadoRepository,EstadoRepository>();
            container.Register<IMensagemRepository,MensagemRepository>();
            container.Register<IPessoaRepository,PessoaRepository>();
            container.Register<IPessoaFisicaRepository,PessoaFisicaRepository>();
            container.Register<IPessoaJuridicaRepository,PessoaJuridicaRepository>();
            container.Register<IPlanoHostRepository,PlanosHostRepository>();
            container.Register<ITicketRepository,TicketRepository>();
            container.Register<ITicketTipoRepository,TicketTipoRepository>();

            //Services
            container.RegisterOpenGeneric(typeof(IBaseDomainService<>), typeof(BaseDomainService<>));
            container.Register<ICidadeDomainService, CidadeDomainService>();
            container.Register<IClienteDomainService, ClienteDomainService>();
            container.Register<IContatoDomainService, ContatoDomainService>();
            container.Register<IEmpresaDomainService, EmpresaDomainService>();
            container.Register<IEnderecoDomainService, EnderecoDomainService>();
            container.Register<IEstadoDomainService, EstadoDomainService>();
            container.Register<IMensagemDomainService, MensagemDomainService>();
            container.Register<IPessoaDomainService, PessoaDomainService>();
            container.Register<IPessoaFisicaDomainService, PessoaFisicaDomainService>();
            container.Register<IPessoaJuridicaDomainService, PessoaJuridicaDomainService>();
            container.Register<IPlanoHostDomainService, PlanoHostDomainService>();
            container.Register<ITicketDomainService, TicketDomainService>();
            container.Register<ITicketTipoDomainService, TicketTipoDomainService>();

            return container;
        }
    }
}
