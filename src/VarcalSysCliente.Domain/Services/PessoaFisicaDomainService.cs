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
    public class PessoaFisicaDomainService: DomainServiceBase<PessoaFisica>, IPessoaFisicaDomainService
    {
        private readonly IPessoaFisicaRepository _pessoaFisicaRepository;

        public PessoaFisicaDomainService(IPessoaFisicaRepository pessoaFisicaRepository)
            : base(pessoaFisicaRepository)
        {
            _pessoaFisicaRepository = pessoaFisicaRepository;
        }
    }
}
