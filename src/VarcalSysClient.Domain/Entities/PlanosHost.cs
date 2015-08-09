using VarcalSysClient.Domain.Entities.Core;

namespace VarcalSysClient.Domain.Entities
{
    public sealed class PlanosHost: BaseEntity
    {
        public string Descricao { get; set; }
        public decimal Valor { get; set; }

    }
}
