using VarcalSysClient.Data.AppDbContext;
using VarcalSysClient.Data.Repositories.Core;
using VarcalSysClient.Domain.Contracts.Repositories;
using VarcalSysClient.Domain.Entities;

namespace VarcalSysClient.Data.Repositories
{
    public class TicketTipoRepository: RepositoryBase<TicketTipo>, ITicketTipoRepository
    {
        public TicketTipoRepository(EfContext dbContext) : base(dbContext)
        {
        }
    }
}
