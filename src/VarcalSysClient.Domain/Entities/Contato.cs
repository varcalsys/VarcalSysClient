using VarcalSysClient.Domain.Entities.Core;

namespace VarcalSysClient.Domain.Entities
{
    public class Contato: BaseEntity
    {
        public string Email { get; set; }
        public string EmailCobranca { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }
        public string Skype { get; set; }
        public int PessoaId { get; set; }
        public virtual Pessoa Pessoa { get; set; }
    }
}
