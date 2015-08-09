using VarcalSysClient.Data.AppDbContext;
using VarcalSysClient.Data.Repositories.Core;
using VarcalSysClient.Domain.Contracts.Repositories;
using VarcalSysClient.Domain.Entities;

namespace VarcalSysClient.Data.Repositories
{
    public class ClienteRepository:RepositoryBase<Cliente>, IClienteRepository
    {
        public ClienteRepository(EfContext dbContext) : base(dbContext)
        {
        }
    }
}
