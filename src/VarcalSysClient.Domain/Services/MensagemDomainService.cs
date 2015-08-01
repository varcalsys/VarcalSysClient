using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VarcalSysClient.Domain.Contracts.Repositories;
using VarcalSysClient.Domain.Contracts.Services;
using VarcalSysClient.Domain.Contracts.Services.Core;
using VarcalSysClient.Domain.Entities;
using VarcalSysClient.Domain.Services.Core;

namespace VarcalSysClient.Domain.Services
{
    public class MensagemDomainService: BaseDomainService<Mensagem>, IMensagemDomainService
    {
        private readonly IMensagemRepository _mensagemRepository;

        public MensagemDomainService(IMensagemRepository mensagemRepository): base(mensagemRepository)
        {
            _mensagemRepository = mensagemRepository;
        }
    }
}
