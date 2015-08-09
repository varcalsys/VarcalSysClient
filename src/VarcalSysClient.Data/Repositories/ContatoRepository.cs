using VarcalSysClient.Data.AppDbContext;
using VarcalSysClient.Data.Repositories.Core;
using VarcalSysClient.Domain.Contracts.Repositories;
using VarcalSysClient.Domain.Entities;

namespace VarcalSysClient.Data.Repositories
{
    public class ContatoRepository: RepositoryBase<Contato>, IContatoRepository
    {
        public ContatoRepository(EfContext dbContext) : base(dbContext)
        {
        }
    }
}
