using VarcalSysClient.Domain.Entities.Core;

namespace VarcalSysClient.Domain.Entities
{
    public class Cidade: BaseEntity
    {
        public string Nome { get; set; }
        public int EstadoId { get; set; }


        public Estado Estado { get; set; }

    }
}
