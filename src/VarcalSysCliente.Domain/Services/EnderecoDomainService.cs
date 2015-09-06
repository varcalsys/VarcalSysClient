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
    public class EnderecoDomainService: DomainServiceBase<Endereco>, IEnderecoDomainService
    {
        private readonly IEnderecoRepository _enderecoRepository;

        public EnderecoDomainService(IEnderecoRepository enderecoRepository):base(enderecoRepository)
        {
            _enderecoRepository = enderecoRepository;
        }
    }
}
