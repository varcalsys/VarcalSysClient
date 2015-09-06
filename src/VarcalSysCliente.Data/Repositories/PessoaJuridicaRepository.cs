using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VarcalSysCliente.Data.ContextDb;
using VarcalSysCliente.Data.Repositories.Core;
using VarcalSysCliente.Domain.Contracts.Repositories;
using VarcalSysCliente.Domain.Entities;

namespace VarcalSysCliente.Data.Repositories
{
    public class PessoaJuridicaRepository: RepositoryBase<PessoaJuridica>, IPessoaJuridicaRepository
    {
        public PessoaJuridicaRepository(EfDbContext db) : base(db)
        {
            _db = db;
        }
    }
}
