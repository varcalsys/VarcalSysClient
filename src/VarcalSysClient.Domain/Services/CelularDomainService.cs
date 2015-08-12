using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VarcalSysClient.Domain.Contracts.Repositories;
using VarcalSysClient.Domain.Contracts.Repositories.Core;
using VarcalSysClient.Domain.Contracts.Services;
using VarcalSysClient.Domain.Entities;
using VarcalSysClient.Domain.Services.Core;

namespace VarcalSysClient.Domain.Services
{
    public class CelularDomainService: DomainServiceBase<Celular>, ICelularDomainService
    {
        private readonly ICelularRepository _celularRepository;
        public CelularDomainService(ICelularRepository celularRepository) 
            : base(celularRepository)
        {
            _celularRepository = celularRepository;
        }
    }
}
