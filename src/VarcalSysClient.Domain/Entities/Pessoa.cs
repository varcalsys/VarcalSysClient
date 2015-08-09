using System;
using VarcalSysClient.Domain.Collections;
using VarcalSysClient.Domain.Entities.Core;
using VarcalSysClient.Domain.Enums;

namespace VarcalSysClient.Domain.Entities
{
    public class Pessoa: BaseEntity
    {
        public PessoaTipo PessoaTipo {get; set;}
        public EnderecoCollection Enderecos { get; set; }
        public ContatoCollection Contatos { get; set; }
        public DateTime DataCadastro { get; set; }
        public virtual PessoaFisica PessoaFisica { get; set; }
        public virtual PessoaJuridica PessoaJuridica { get; set; }
    }
    
}
