using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarcalSysCliente.Domain.Entities
{
    public sealed class Contato
    {
        public int Id { get; private set; }
        public string Email { get; private set; }
        public string EmailCobranca { get; private set; }
        public string Telefone { get; private set; }
        public string Celular { get; private set; }


        protected Contato()
        {
            
        }

        public Contato(string email, string emailCobranca, string telefone, string celular)
        {
            Email = email;
            EmailCobranca = emailCobranca;
            Telefone = telefone;
            Celular = celular;
        }
    }

}
