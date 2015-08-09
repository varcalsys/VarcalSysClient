using VarcalSysClient.Domain.Contracts.Repositories;
using VarcalSysClient.Domain.Contracts.Services;
using VarcalSysClient.Domain.Entities;
using VarcalSysClient.Domain.Services.Core;

namespace VarcalSysClient.Domain.Services
{
    public class CidadeDomainService: DomainServiceBase<Cidade>, ICidadeDomainService
    {

        private readonly ICidadeRepository _cidadeRepository;

        public CidadeDomainService(ICidadeRepository cidadeRepository):base(cidadeRepository)
        {
            _cidadeRepository = cidadeRepository;
        }
    }
}
