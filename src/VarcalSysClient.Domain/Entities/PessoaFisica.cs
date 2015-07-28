using System;
using VarcalSysClient.Domain.Entities.Base;

namespace VarcalSysClient.Domain.Entities
{
    public sealed class PessoaFisica: BaseEntity
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Rg { get; set; }
        public DateTime DataNascimento { get; set; }
        public Sexo Sexo { get; set; }

        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }
    }


    public enum Sexo
    {
        Masculino = 1,
        Feminino = 2
    }
}
