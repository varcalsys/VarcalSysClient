using VarcalSysClient.Domain.Entities.Core;

namespace VarcalSysClient.Domain.Entities
{
    public sealed class PlanoHost: BaseEntity
    {
        public string Descricao { get; set; }
        public decimal Valor { get; set; }

    }
}
