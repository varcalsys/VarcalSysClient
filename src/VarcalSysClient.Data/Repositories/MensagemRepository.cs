using VarcalSysClient.Data.AppDbContext;
using VarcalSysClient.Data.Repositories.Core;
using VarcalSysClient.Domain.Contracts.Repositories;
using VarcalSysClient.Domain.Entities;

namespace VarcalSysClient.Data.Repositories
{
    public class MensagemRepository: RepositoryBase<Mensagem>, IMensagemRepository
    {
        public MensagemRepository(EfContext dbContext) : base(dbContext)
        {
        }
    }
}
