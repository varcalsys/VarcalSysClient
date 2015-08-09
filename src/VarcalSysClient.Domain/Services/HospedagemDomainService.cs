using VarcalSysClient.Domain.Contracts.Repositories;
using VarcalSysClient.Domain.Contracts.Services;
using VarcalSysClient.Domain.Entities;
using VarcalSysClient.Domain.Services.Core;

namespace VarcalSysClient.Domain.Services
{
    public class HospedagemDomainService: DomainServiceBase<Hospedagem>, IHospdagemDomainService
    {
        private IHospedagemRepository _empresaRepository;

        public HospedagemDomainService(IHospedagemRepository empresaRepository) : base(empresaRepository)
        {
            _empresaRepository = empresaRepository;
        }
    }
}
