using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VarcalSysClient.Domain.Entities.Core;

namespace VarcalSysClient.Domain.Entities
{
    public class Empresa: BaseEntity
    {
        public int PessoaId { get; set; }
        public Pessoa Pessoa { get; set; }
    }
}
