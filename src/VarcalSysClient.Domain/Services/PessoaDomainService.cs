using VarcalSysClient.Domain.Contracts.Repositories;
using VarcalSysClient.Domain.Contracts.Services;
using VarcalSysClient.Domain.Entities;
using VarcalSysClient.Domain.Services.Core;

namespace VarcalSysClient.Domain.Services
{
    public class PessoaDomainService: DomainServiceBase<Pessoa>, IPessoaDomainService
    {
        private readonly IPessoaRepository _pessoaRepository;

        public PessoaDomainService(IPessoaRepository pessoaRepository): base(pessoaRepository)
        {
            _pessoaRepository = pessoaRepository;
        }
    }
}
