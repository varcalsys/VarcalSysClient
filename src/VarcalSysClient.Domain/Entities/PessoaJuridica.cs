using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VarcalSysClient.Domain.Entities.Core;

namespace VarcalSysClient.Domain.Entities
{
    public  class PessoaJuridica: BaseEntity
    {
        public string RazaoSocial { get; set; }
        public string Cnpj { get; set; }
            
        public virtual Pessoa Pessoa { get; set; }

    }
}
