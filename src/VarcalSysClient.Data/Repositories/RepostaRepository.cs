using VarcalSysClient.Data.AppDbContext;
using VarcalSysClient.Data.Repositories.Core;
using VarcalSysClient.Domain.Contracts.Repositories;
using VarcalSysClient.Domain.Entities;

namespace VarcalSysClient.Data.Repositories
{
    public class RepostaRepository: RepositoryBase<Resposta>, IRespostaRepository
    {
        
        public RepostaRepository(EfContext dbContext) : base(dbContext)
        {
            
        }
    }
}
