using VarcalSysClient.Domain.Collections;
using VarcalSysClient.Domain.Entities;
using VarcalSysClient.Domain.Enums;

namespace VarcalSysClient.Web.Models
{
    public class ClienteViewModelRegister
    {
        public int Id { get; set; }
        public int PessoaTipoId { get; set; }
        public PessoaFisica PessoaFisica { get; set; }
        public PessoaJuridica PessoaJuridica { get; set; }
        public EnderecoCollection EnderecoCollection { get; set; }
        public TelefoneCollection TelefoneCollection { get; set; }
        public CelularCollection CelularCollection { get; set; }
        public EmailCollection EmailCollection { get; set; }
        public int PlanoHostId { get; set; }

        public ClienteViewModelRegister()
        {
            EnderecoCollection = new EnderecoCollection();
            CelularCollection = new CelularCollection();
            EmailCollection = new EmailCollection();
            TelefoneCollection = new TelefoneCollection();
        }
    }
}