using VarcalSysClient.Data.AppDbContext;
using VarcalSysClient.Data.Repositories.Core;
using VarcalSysClient.Domain.Contracts.Repositories;
using VarcalSysClient.Domain.Entities;

namespace VarcalSysClient.Data.Repositories
{
    public class EstadoRepository: RepositoryBase<Estado>, IEstadoRepository
    {
        public EstadoRepository(EfContext dbContext) : base(dbContext)
        {
        }
    }
}
