using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VarcalSysClient.Domain.Entities.Base;

namespace VarcalSysClient.Domain.Entities
{
    public class Cidade: BaseEntity
    {
        public string Nome { get; set; }
        public int EstadoId { get; set; }


        public Estado Estado { get; set; }

    }
}
