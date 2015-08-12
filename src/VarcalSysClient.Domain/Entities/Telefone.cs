using VarcalSysClient.Domain.Entities.Core;
using VarcalSysClient.Domain.Enums;

namespace VarcalSysClient.Domain.Entities
{
    public class Telefone: BaseEntity
    {
        #region Propriedades

        public string Numero { get;  set; }
        public TelefoneTipo TelefoneTipo { get;  set; }
        public string Ramal { get;  set; }
        public int PessoaId { get;  set; }
        public virtual Pessoa Pessoa { get; set; }

        #endregion


        #region Construtores

        protected Telefone()
        {
           
        }

        //public Telefone(int pessoaId, string numero, TelefoneTipo telefoneTipo, [Optional] String ramal)
        //{
        //    AssertionConcern.AssertArgumentNotEmpty(numero,Errors.RequiredField);
        //    AssertionConcern.AssertArgumentNotEquals((int)telefoneTipo,0,Errors.RequiredField);
        //    PessoaId = pessoaId;
        //    Numero = numero;
        //    TelefoneTipo = telefoneTipo;
        //    Ramal = ramal;
        //}

        #endregion


        #region Métodos

        //public void SetNumero(string numero)
        //{
        //    Numero = numero;
        //}

        //public void SetTelefoneTipo(TelefoneTipo telefoneTipo)
        //{
        //    TelefoneTipo = telefoneTipo;
        //}

        //public void SetRamal(string ramal)
        //{
        //    Ramal = ramal;
        //}

        //public void SetPessoaId(int pessoaId)
        //{
        //    PessoaId = pessoaId;
        //}

        #endregion       
    }

}
