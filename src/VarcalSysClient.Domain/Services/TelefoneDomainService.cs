using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VarcalSysClient.Domain.Contracts.Repositories;
using VarcalSysClient.Domain.Contracts.Services;
using VarcalSysClient.Domain.Entities;
using VarcalSysClient.Domain.Services.Core;

namespace VarcalSysClient.Domain.Services
{
    public class TelefoneDomainService: DomainServiceBase<Telefone>, ITelefoneDomainService
    {
        private readonly ITelefoneRepository _telefoneRepository;

        public TelefoneDomainService(ITelefoneRepository telefoneRepository)
            :base(telefoneRepository)
        {
            _telefoneRepository = telefoneRepository;
        }
    }
}
