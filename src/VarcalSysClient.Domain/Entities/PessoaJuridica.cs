using VarcalSysClient.Domain.Entities.Core;

namespace VarcalSysClient.Domain.Entities
{
    public  class PessoaJuridica: BaseEntity
    {
        public string RazaoSocial { get; set; }
        public string Cnpj { get; set; }
        public string PessoaResponsavel { get; set; }
        public string EmailResponsavel { get; set; }
        public virtual Pessoa Pessoa { get; set; }

    }
}
