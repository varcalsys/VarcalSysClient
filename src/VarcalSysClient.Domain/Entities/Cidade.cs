using VarcalSysClient.Domain.Entities.Core;

namespace VarcalSysClient.Domain.Entities
{
    public class Cidade: BaseEntity
    {
        public string Nome { get; set; }
        
        public virtual Estado Estado { get; set; }
        public int EstadoId { get; set; }
    }
}
