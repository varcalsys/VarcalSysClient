using VarcalSysClient.Data.AppDbContext;
using VarcalSysClient.Data.Repositories.Core;
using VarcalSysClient.Domain.Contracts.Repositories;
using VarcalSysClient.Domain.Entities;

namespace VarcalSysClient.Data.Repositories
{
    public class CidadeRepository: RepositoryBase<Cidade>, ICidadeRepository
    {
        public CidadeRepository(EfContext dbContext) : base(dbContext)
        {
        }
    }
}
