using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using VarcalSysClient.Domain.Entities.Base;

namespace VarcalSysClient.Domain.Entities
{
    public sealed class Endereco: BaseEntity
    {
        public string Logradouro { get; set; }
        public int Numero { get; set; }
        public string Complemento { get; set; }
        public string Cep { get; set; }
        public string Bairro { get; set; }

        public Cidade Cidade { get; set; }
        public int CidadeId { get; set; }
        
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }

    }
}
