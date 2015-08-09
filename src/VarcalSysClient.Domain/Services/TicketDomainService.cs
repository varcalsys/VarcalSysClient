using VarcalSysClient.Domain.Contracts.Repositories;
using VarcalSysClient.Domain.Contracts.Services;
using VarcalSysClient.Domain.Entities;
using VarcalSysClient.Domain.Services.Core;

namespace VarcalSysClient.Domain.Services
{
    public class TicketDomainService: DomainServiceBase<Ticket>, ITicketDomainService
    {
        private readonly ITicketRepository _ticketRepository;

        public TicketDomainService(ITicketRepository ticketRepository)
            :base(ticketRepository)
        {
            _ticketRepository = ticketRepository;
        }
    }
}
