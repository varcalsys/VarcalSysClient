using VarcalSysClient.Domain.Contracts.Repositories;
using VarcalSysClient.Domain.Contracts.Services;
using VarcalSysClient.Domain.Entities;
using VarcalSysClient.Domain.Services.Core;

namespace VarcalSysClient.Domain.Services
{
    public class TicketTipoDomainService: DomainServiceBase<TicketTipo>, ITicketTipoDomainService
    {
        private readonly ITicketTipoRepository _ticketTipoRepository;

        public TicketTipoDomainService(ITicketTipoRepository ticketTipoRepository)
            :base(ticketTipoRepository)
        {
            _ticketTipoRepository = ticketTipoRepository;
        }
    }
}
