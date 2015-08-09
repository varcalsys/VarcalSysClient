using System;
using VarcalSysClient.Domain.Entities.Core;

namespace VarcalSysClient.Domain.Entities
{
    public sealed class Mensagem: BaseEntity
    {
        public string Texto { get; set; }
        public DateTime DataCadastro { get; set; }
       
    }
}
