using System;
using VarcalSysClient.Domain.Entities.Core;

namespace VarcalSysClient.Domain.Entities
{
    public class Email: BaseEntity
    {

        #region Propriedades

        public String Endereco { get; private set; }
        public int PessoaId { get; private set; }
        public virtual Pessoa Pessoa { get; set; }

        #endregion


        #region Construtores

        protected Email()
        {

        }

        //public Email(int pessoaId, string endereco)
        //{
        //    AssertionConcern.AssertArgumentNotEmpty(endereco,Errors.RequiredField);

        //    PessoaId = pessoaId;
        //    Endereco = endereco;
        //}

        #endregion


        #region Métodos

        //public void SetEndereco(string endereco)
        //{
        //    Endereco = endereco;
        //}

        //public void SetPessoaId(int pessoaId)
        //{
        //    PessoaId = pessoaId;
        //}

        #endregion

    }
}
