using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VarcalSysCliente.Domain.Entities;

namespace VarcalSysCliente.Web.Models
{
    public class PlanoHostViewModel
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public decimal Valor { get; set; }

        public PlanoHostViewModel(PlanoHost entity)
        {
            Id = entity.Id;
            Descricao = entity.Descricao;
            Valor = entity.Valor;
        }
    }



}