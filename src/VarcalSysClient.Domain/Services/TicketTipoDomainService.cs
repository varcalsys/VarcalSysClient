using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VarcalSysClient.Domain.Contracts.Repositories;
using VarcalSysClient.Domain.Contracts.Services;
using VarcalSysClient.Domain.Entities;
using VarcalSysClient.Domain.Services.Core;

namespace VarcalSysClient.Domain.Services
{
    public class TicketTipoDomainService: BaseDomainService<TicketTipo>, ITicketTipoDomainService
    {
        private readonly ITicketTipoRepository _ticketTipoRepository;

        public TicketTipoDomainService(ITicketTipoRepository ticketTipoRepository)
            :base(ticketTipoRepository)
        {
            _ticketTipoRepository = ticketTipoRepository;
        }
    }
}
