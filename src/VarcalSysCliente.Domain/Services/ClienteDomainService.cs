using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VarcalSysCliente.Domain.Contracts.Core;
using VarcalSysCliente.Domain.Contracts.Repositories;
using VarcalSysCliente.Domain.Contracts.Services;
using VarcalSysCliente.Domain.Entities;
using VarcalSysCliente.Domain.Services.Core;

namespace VarcalSysCliente.Domain.Services
{
    public class ClienteDomainService: DomainServiceBase<Cliente>, IClienteDomainService
    {
        private readonly IClienteRepository _clienteRepository;
        public ClienteDomainService(IClienteRepository clienteRepository)
            : base(clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }
    }
}
