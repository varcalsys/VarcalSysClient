using SimpleInjector;
using SimpleInjector.Extensions;
using VarcalSysClient.App;
using VarcalSysClient.App.Contracts;
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
            container.RegisterOpenGeneric(typeof(IRepositoryBase<>),typeof(RepositoryBase<>));
            container.Register<ICidadeRepository,CidadeRepository>();
            container.Register<IClienteRepository,ClienteRepository>();
            container.Register<IHospedagemRepository,HospedagemRepository>();
            container.Register<IEnderecoRepository,EnderecoRepository>();
            container.Register<IEstadoRepository,EstadoRepository>();
            container.Register<IMensagemRepository,MensagemRepository>();
            container.Register<IPessoaRepository,PessoaRepository>();
            container.Register<IPessoaFisicaRepository,PessoaFisicaRepository>();
            container.Register<IPessoaJuridicaRepository,PessoaJuridicaRepository>();
            container.Register<IPlanoHostRepository,PlanosHostRepository>();
            container.Register<ITicketRepository,TicketRepository>();
            container.Register<ITicketTipoRepository,TicketTipoRepository>();
            container.Register<ITelefoneRepository,TelefoneRepository>();
            container.Register<ICelularRepository, CelularRepository>();
            container.Register<IEmailRepository,EmailRepository>();
           

            //Services
            container.RegisterOpenGeneric(typeof(IDomainServiceBase<>), typeof(DomainServiceBase<>));
            container.Register<ICidadeDomainService, CidadeDomainService>();
            container.Register<IClienteDomainService, ClienteDomainService>();
            container.Register<IHospdagemDomainService, HospedagemDomainService>();
            container.Register<IEnderecoDomainService, EnderecoDomainService>();
            container.Register<IEstadoDomainService, EstadoDomainService>();
            container.Register<IMensagemDomainService, MensagemDomainService>();
            container.Register<IPessoaDomainService, PessoaDomainService>();
            container.Register<IPessoaFisicaDomainService, PessoaFisicaDomainService>();
            container.Register<IPessoaJuridicaDomainService, PessoaJuridicaDomainService>();
            container.Register<IPlanoHostDomainService, PlanoHostDomainService>();
            container.Register<ITicketDomainService, TicketDomainService>();
            container.Register<ITicketTipoDomainService, TicketTipoDomainService>();
            container.Register<ITelefoneDomainService, TelefoneDomainService>();
            container.Register<ICelularDomainService, CelularDomainService>();
            container.Register<IEmailDomainService, EmailDomainService>();

            //App
            container.Register<IClienteAppService, ClienteAppService>();

            return container;
        }
    }
}
