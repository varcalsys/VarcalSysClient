using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VarcalSysClient.Domain.Entities.Base;

namespace VarcalSysClient.Domain.Entities
{
    public sealed class PessoaJuridica: BaseEntity
    {
        public string RazaoSocial { get; set; }
        public string Cnpj { get; set; }
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }

    }
}
