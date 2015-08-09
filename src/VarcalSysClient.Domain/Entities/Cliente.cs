using VarcalSysClient.Domain.Entities.Core;

namespace VarcalSysClient.Domain.Entities
{
    public class Cliente: BaseEntity
    {        
        public virtual PlanosHost PlanosHost { get; set; }
        public int PlanosHostId { get; set; }
        public Pessoa Pessoa { get; set; }
        public int PessoaId { get; set; }
    }
}
