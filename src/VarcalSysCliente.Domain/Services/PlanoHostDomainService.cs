using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VarcalSysCliente.Domain.Contracts.Repositories;
using VarcalSysCliente.Domain.Contracts.Services;
using VarcalSysCliente.Domain.Entities;
using VarcalSysCliente.Domain.Services.Core;

namespace VarcalSysCliente.Domain.Services
{
    public class PlanoHostDomainService: DomainServiceBase<PlanoHost>, IPlanoHostDomainService
    {
        private readonly IPlanoHostRepository _planoHostRepository;

        public PlanoHostDomainService(IPlanoHostRepository planoHostRepository)
            :base(planoHostRepository)
        {
            _planoHostRepository = planoHostRepository;
        }
    }
}
