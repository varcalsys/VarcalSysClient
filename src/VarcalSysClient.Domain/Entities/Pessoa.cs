using System;
using VarcalSysClient.Domain.Collections;
using VarcalSysClient.Domain.Entities.Core;
using VarcalSysClient.Domain.Enums;

namespace VarcalSysClient.Domain.Entities
{
    public class Pessoa: BaseEntity
    {
        public PessoaTipo PessoaTipo {get; set;}
        public EnderecoCollection EnderecoCollection { get; set; }
        public TelefoneCollection TelefoneCollection { get; set; }
        public CelularCollection CelularCollection { get; set; }
        public EmailCollection EmailCollection { get; set; }
        public DateTime DataCadastro { get; set; }
        public virtual PessoaFisica PessoaFisica { get; set; }
        public virtual PessoaJuridica PessoaJuridica { get; set; }


        public Pessoa()
        {
            EnderecoCollection = new EnderecoCollection();
            CelularCollection = new CelularCollection();
            EmailCollection = new EmailCollection();
            TelefoneCollection = new TelefoneCollection();
        }
    }
    
}
