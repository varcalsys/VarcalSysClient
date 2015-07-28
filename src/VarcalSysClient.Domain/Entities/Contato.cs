using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VarcalSysClient.Domain.Entities.Base;

namespace VarcalSysClient.Domain.Entities
{
    public sealed class Contato: BaseEntity
    {
        public string Email { get; set; }
        public string EmailCobranca { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }
        public string Skype { get; set; }

        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }
    }
}
