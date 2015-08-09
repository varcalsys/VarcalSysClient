using VarcalSysClient.Domain.Contracts.Repositories;
using VarcalSysClient.Domain.Contracts.Services;
using VarcalSysClient.Domain.Entities;
using VarcalSysClient.Domain.Services.Core;

namespace VarcalSysClient.Domain.Services
{
    public class EstadoDomainService: DomainServiceBase<Estado>, IEstadoDomainService
    {
        private readonly IEstadoRepository _estadoRepository;

        public EstadoDomainService(IEstadoRepository estadoRepository) : base(estadoRepository)
        {
            _estadoRepository = estadoRepository;
        }
    }
}
