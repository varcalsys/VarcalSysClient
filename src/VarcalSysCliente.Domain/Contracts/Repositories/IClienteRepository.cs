using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VarcalSysCliente.Domain.Contracts.Core;
using VarcalSysCliente.Domain.Entities;

namespace VarcalSysCliente.Domain.Contracts.Repositories
{
    public interface IClienteRepository: IRepositoryBase<Cliente>
    {
    }
}
