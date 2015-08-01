using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace VarcalSysClient.Domain.Entities
{
    public class Cliente
    {
        public int Id { get; set; }
        public PlanosHost PlanosHost { get; set; }
        public int PlanosHostId { get; set; }
        public Pessoa Pessoa { get; set; }
        public int PessoaId { get; set; }
    }
}
