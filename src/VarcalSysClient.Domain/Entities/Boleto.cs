using System;
using VarcalSysClient.Domain.Entities.Core;

namespace VarcalSysClient.Domain.Entities
{
    public class Boleto: BaseEntity
    {
        public DateTime DataVencimento { get; set; }
        public string Url { get; set; }
        public virtual Cliente Cliente { get; set; }
        public int ClienteId { get; set; }
    }
}
