using VarcalSysClient.Domain.Contracts.Repositories;
using VarcalSysClient.Domain.Contracts.Services;
using VarcalSysClient.Domain.Entities;
using VarcalSysClient.Domain.Services.Core;

namespace VarcalSysClient.Domain.Services
{
    public class PlanoHostDomainService: DomainServiceBase<PlanosHost>, IPlanoHostDomainService
    {
        private readonly IPlanoHostRepository _planoHostRepository;

        public PlanoHostDomainService(IPlanoHostRepository planoHostRepository)
            :base(planoHostRepository)
        {
            _planoHostRepository = planoHostRepository;
        }
    }
}
