using VarcalSysClient.Data.AppDbContext;
using VarcalSysClient.Data.Repositories.Core;
using VarcalSysClient.Domain.Contracts.Repositories;
using VarcalSysClient.Domain.Entities;

namespace VarcalSysClient.Data.Repositories
{
    public class PlanosHostRepository: RepositoryBase<PlanoHost>, IPlanoHostRepository
    {
        public PlanosHostRepository(EfContext dbContext) : base(dbContext)
        {
        }
    }
}
