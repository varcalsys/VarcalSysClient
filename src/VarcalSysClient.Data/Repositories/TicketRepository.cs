using VarcalSysClient.Data.AppDbContext;
using VarcalSysClient.Data.Repositories.Core;
using VarcalSysClient.Domain.Contracts.Repositories;
using VarcalSysClient.Domain.Entities;

namespace VarcalSysClient.Data.Repositories
{
    public class TicketRepository: RepositoryBase<Ticket>, ITicketRepository
    {
        public TicketRepository(EfContext dbContext) : base(dbContext)
        {
        }
    }
}
