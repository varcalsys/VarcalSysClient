﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VarcalSysCliente.Domain.ValueObjects;

namespace VarcalSysCliente.Domain.Entities
{
    public sealed class Endereco
    {
        public int Id { get; set; }
        public string Logradouro { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }       
        public Uf Uf { get; set; }
    }
}
