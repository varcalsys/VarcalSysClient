using System;
using VarcalSysClient.Domain.Collections;
using VarcalSysClient.Domain.Entities.Core;

namespace VarcalSysClient.Domain.Entities
{
    public class Ticket: BaseEntity
    {       
       
        public DateTime DataCadastro { get; set; }          
        public bool EmAberto { get; set; }
        public RespostaCollection Repostas { get; set; }
        public int TicketTipoId { get; set; }
        public virtual TicketTipo TicketTipo { get; set; }
        public virtual Cliente Cliente { get; set; }
        public int ClienteId { get; set; }
        public int MensagemId { get; set; }
        public virtual Mensagem Mensagem { get; set; }

    }
}
