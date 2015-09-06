using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject.Modules;
using VarcalSysCliente.Data.ContextDb;
using VarcalSysCliente.Data.Repositories;
using VarcalSysCliente.Domain.Contracts.Core;
using VarcalSysCliente.Domain.Contracts.Repositories;
using VarcalSysCliente.Domain.Contracts.Services;
using VarcalSysCliente.Domain.Services;
using VarcalSysCliente.Domain.Services.Core;

namespace VarcalSysCliente.IoC
{
    public class IoCModule: NinjectModule
    {
        public override void Load()
        {
            //Application

            //Domain
            Bind(typeof(IDomainServiceBase<>)).To(typeof(DomainServiceBase<>));
            Bind<IClienteDomainService>().To<ClienteDomainService>();
            Bind<IContatoDomainService>().To<ContatoDomainService>();
            Bind<IEnderecoDomainService>().To<EnderecoDomainService>();
            Bind<IPessoaFisicaDomainService>().To<PessoaFisicaDomainService>();
            Bind<IPessoaJuridicaDomainService>().To<PessoaJuridicaDomainService>();
            Bind<IPlanoHostDomainService>().To<PlanoHostDomainService>();

            //Repositories
            Bind<EfDbContext>().To<EfDbContext>();
            Bind(typeof(IRepositoryBase<>)).To(typeof(IRepositoryBase<>));
            Bind<IClienteRepository>().To<ClienteRepository>();
            Bind<IContatoRepository>().To<ContatoRepository>();
            Bind<IEnderecoRepository>().To<EnderecoRepository>();
            Bind<IPessoaFisicaRepository>().To<PessoaFisicaRepository>();
            Bind<IPessoaJuridicaRepository>().To<PessoaJuridicaRepository>();
            Bind<IPlanoHostRepository>().To<PlanoHostRepository>();
        }
    }
}
