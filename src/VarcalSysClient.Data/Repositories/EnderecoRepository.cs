using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VarcalSysClient.Data.AppDbContext;
using VarcalSysClient.Data.Repositories.Base;
using VarcalSysClient.Domain.Contracts.Repositories;
using VarcalSysClient.Domain.Entities;

namespace VarcalSysClient.Data.Repositories
{
    public class EnderecoRepository: BaseRepository<Endereco>, IEnderecoRepository
    {
        public EnderecoRepository(EfContext dbContext) : base(dbContext)
        {
        }
    }
}
