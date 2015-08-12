using VarcalSysClient.Domain.Collections;
using VarcalSysClient.Domain.Entities;

namespace VarcalSysClient.App.Dto
{
    public class ClienteDto
    {
        public virtual PlanoHost PlanosHost { get; set; }
        public int PlanosHostId { get; set; }
        public Pessoa Pessoa { get; set; }
        public int PessoaId { get; set; }
        public BoletoCollection Boletos { get; set; }
    }
}
