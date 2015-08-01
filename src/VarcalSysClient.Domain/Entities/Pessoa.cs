using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VarcalSysClient.Domain.Collections;
using VarcalSysClient.Domain.Entities.Base;
using VarcalSysClient.Domain.Enums;

namespace VarcalSysClient.Domain.Entities
{
    public sealed class Pessoa: BaseEntity
    {
        public PessoaTipo PessoaTipo {get; set;}
        public EnderecoCollection Enderecos { get; set; }
        public ContatoCollection Contatos { get; set; }
        public DateTime DataCadastro { get; set; }

        public PessoaFisica PessoaFisica { get; set; }
        public PessoaJuridica PessoaJuridica { get; set; }



    }
    
}
