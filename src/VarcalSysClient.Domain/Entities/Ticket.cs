using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VarcalSysClient.Domain.Entities.Base;

namespace VarcalSysClient.Domain.Entities
{
    public class Ticket: BaseEntity
    {       
       
        public DateTime DataCadastro { get; set; }
        public DateTime DataResposta { get; set; }
        public List<Mensagem> Mensagens { get; set; }
        public bool EmAberto { get; set; }
        public int TicketTipoId { get; set; }
        public virtual TicketTipo TicketTipo { get; set; }
        public Empresa Empresa { get; set; }
        public int? EmpresaId { get; set; }
        public Cliente Cliente { get; set; }
        public int ClienteId { get; set; }

    }
}
