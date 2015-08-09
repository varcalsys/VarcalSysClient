using VarcalSysClient.Domain.Contracts.Repositories;
using VarcalSysClient.Domain.Entities;
using VarcalSysClient.Domain.Services.Core;

namespace VarcalSysClient.Domain.Services
{
    public class RespostaDomainService: DomainServiceBase<Resposta>
    {
        private readonly IRespostaRepository _respostaRepository;

        public RespostaDomainService(IRespostaRepository respostaRepository)
            :base(respostaRepository)
        {
            _respostaRepository = respostaRepository;
        }
    }
}
