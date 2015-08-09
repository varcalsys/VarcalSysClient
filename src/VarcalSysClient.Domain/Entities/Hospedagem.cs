using VarcalSysClient.Domain.Entities.Core;

namespace VarcalSysClient.Domain.Entities
{
    public class Hospedagem: BaseEntity
    {
        public int PessoaId { get; set; }
        public Pessoa Pessoa { get; set; }  
    }
}
