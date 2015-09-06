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
    public class ContatoDomainService:DomainServiceBase<Contato>, IContatoDomainService
    {
        private readonly IContatoRepository _contatoRepository;
        public ContatoDomainService(IContatoRepository contatoRepository)
            : base(contatoRepository)
        {
            _contatoRepository = contatoRepository;
        }
    }
}
