using VarcalSysClient.Data.AppDbContext;
using VarcalSysClient.Data.Repositories.Core;
using VarcalSysClient.Domain.Contracts.Repositories;
using VarcalSysClient.Domain.Entities;

namespace VarcalSysClient.Data.Repositories
{
    public class BoletoRepository: RepositoryBase<Boleto>, IBoletoRepository
    {
        public BoletoRepository(EfContext dbContext) : base(dbContext)
        {
        }
    }
}
