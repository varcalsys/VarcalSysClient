using VarcalSysClient.Domain.Enums;

namespace VarcalSysClient.Web.Models
{
    public class ClienteViewModel
    {
        public int Id { get; set; }
        public PessoaTipo PessoaTipo { get; set; }
        public string NomeRazaoSocial { get; set; }
        public string CpfCnpj { get; set; }
        
    }
}