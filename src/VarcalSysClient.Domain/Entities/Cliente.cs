using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VarcalSysClient.Domain.Entities.Base;
using VarcalSysClient.Domain.Enums;

namespace VarcalSysClient.Domain.Entities
{
    public sealed class Cliente: BaseEntity
    {
        public PessoaTipo PessoaTipo {get; set;}
        public List<Endereco> Enderecos { get; set; }
        public List<Contato> Contatos { get; set; }
        public DateTime DataCadastro { get; set; }
        public int PlanoHostId { get; set; }
        public PlanosHost PlanoHost { get; set; }

    }

    
}
