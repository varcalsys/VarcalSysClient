using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VarcalSysClient.Domain.Entities.Base;

namespace VarcalSysClient.Domain.Entities
{
    public sealed class Mensagem: BaseEntity
    {
        public string Texto { get; set; }
        public DateTime DataCadastro { get; set; }
        public int TicketId { get; set; }
        public Ticket Ticket { get; set; }
    }
}
