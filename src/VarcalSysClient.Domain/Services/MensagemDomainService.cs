using VarcalSysClient.Domain.Contracts.Repositories;
using VarcalSysClient.Domain.Contracts.Services;
using VarcalSysClient.Domain.Entities;
using VarcalSysClient.Domain.Services.Core;

namespace VarcalSysClient.Domain.Services
{
    public class MensagemDomainService: DomainServiceBase<Mensagem>, IMensagemDomainService
    {
        private readonly IMensagemRepository _mensagemRepository;

        public MensagemDomainService(IMensagemRepository mensagemRepository): base(mensagemRepository)
        {
            _mensagemRepository = mensagemRepository;
        }
    }
}
