using VarcalSysClient.Domain.Entities.Core;

namespace VarcalSysClient.Domain.Entities
{
    public class Endereco: BaseEntity
    {
        public string Logradouro { get; set; }
        public int Numero { get; set; }
        public string Complemento { get; set; }
        public string Cep { get; set; }
        public string Bairro { get; set; }

        public virtual Cidade Cidade { get; set; }
        public int CidadeId { get; set; }

        public int PessoaId { get; set; }
        public virtual Pessoa Pessoa { get; set; }

        public Endereco()
        {
            Cidade = new Cidade();
            Pessoa = new Pessoa();
        }

    }
}
