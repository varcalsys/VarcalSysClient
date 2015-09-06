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
    public class ClienteRepository: RepositoryBase<Cliente>, IClienteRepository
    {      
        public ClienteRepository(EfDbContext db) : base(db)
        {
            _db = db;
        }
    }
}
