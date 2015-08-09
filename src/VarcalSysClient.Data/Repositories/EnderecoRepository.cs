using VarcalSysClient.Data.AppDbContext;
using VarcalSysClient.Data.Repositories.Core;
using VarcalSysClient.Domain.Contracts.Repositories;
using VarcalSysClient.Domain.Entities;

namespace VarcalSysClient.Data.Repositories
{
    public class EnderecoRepository: RepositoryBase<Endereco>, IEnderecoRepository
    {
        public EnderecoRepository(EfContext dbContext) : base(dbContext)
        {
        }
    }
}
