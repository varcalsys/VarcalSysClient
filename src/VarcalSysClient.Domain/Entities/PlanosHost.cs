using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VarcalSysClient.Domain.Entities.Core;

namespace VarcalSysClient.Domain.Entities
{
    public sealed class PlanosHost: BaseEntity
    {
        public string Descricao { get; set; }
        public decimal Valor { get; set; }

    }
}
