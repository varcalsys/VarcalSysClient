using System;
using VarcalSysClient.Domain.Entities.Core;
using VarcalSysClient.Domain.Enums;

namespace VarcalSysClient.Domain.Entities
{
    public class Celular: BaseEntity
    {
        public String Numero { get;  set; }
        public Operadora Operadora { get;  set; }
        public int PessoaId { get;  set; }

        public virtual Pessoa Pessoa { get; set; }

        protected Celular()
        {
            
        }

        //public Celular(int pessoaId,string numero, Operadora operadora)
        //{

        //    AssertionConcern.AssertArgumentNotEmpty(numero,Errors.RequiredField);

        //    PessoaId = pessoaId;
        //    Numero = numero;
        //    Operadora = operadora;
        //}


        //public void SetNumero(string numero)
        //{
        //    Numero = numero;
        //}

        //public void SetOperadora(Operadora operadora)
        //{
        //    Operadora = operadora;
        //}

        //public void SetPessoaId(int pessoaId)
        //{
        //    PessoaId = pessoaId;
        //}
    }
}
