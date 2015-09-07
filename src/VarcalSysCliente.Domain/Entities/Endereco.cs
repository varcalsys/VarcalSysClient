using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using VarcalSysCliente.Domain.ValueObjects;

namespace VarcalSysCliente.Domain.Entities
{
    public sealed class Endereco
    {
        public int Id { get; private set; }
        public string Logradouro { get; private set; }
        public string Bairro { get; private set; }
        public string Cidade { get; private set; }       
        public Uf Uf { get; private set; }

        protected Endereco()
        {
           
        }

        public Endereco(string logradouro, string cidade, Uf uf, [Optional] string bairro)
        {
            Logradouro = logradouro;
            Bairro = bairro;
            Cidade = cidade;
            Uf = uf;
        }
    }
}
