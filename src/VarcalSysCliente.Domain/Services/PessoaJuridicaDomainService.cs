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
    public class PessoaJuridicaDomainService: DomainServiceBase<PessoaJuridica>, IPessoaJuridicaDomainService
    {
        private readonly IPessoaJuridicaRepository _pessoaJuridicaRepository;

        public PessoaJuridicaDomainService(IPessoaJuridicaRepository pessoaJuridicaRepository)
            :base(pessoaJuridicaRepository)
        {
            _pessoaJuridicaRepository = pessoaJuridicaRepository;
        }
    }
}
