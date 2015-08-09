using VarcalSysClient.Domain.Collections;
using VarcalSysClient.Domain.Entities.Core;

namespace VarcalSysClient.Domain.Entities
{
    public class Cliente: BaseEntity
    {        
        public virtual PlanoHost PlanosHost { get; set; }
        public int PlanosHostId { get; set; }
        public Pessoa Pessoa { get; set; }
        public int PessoaId { get; set; }
        public BoletoCollection Boletos { get; set; }
    }
}
