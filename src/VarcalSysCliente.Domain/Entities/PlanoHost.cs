using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarcalSysCliente.Domain.Entities
{
    public sealed class PlanoHost
    {
        public int Id { get; private set; }
        public string Descricao { get; private set; }
        public decimal Valor { get; private set; }
        public bool Ativo { get; set; }

        public PlanoHost(string descricao, decimal valor)
        {
            if(string.IsNullOrEmpty(descricao))
                throw new ApplicationException("Descricão obrgatória");
            if (valor <= 0)
                throw new ApplicationException("Valor obrigatório");
            Descricao = descricao;
            Valor = valor;
        }
    }
}
