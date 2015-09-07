using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VarcalSysCliente.Domain.Entities;
using VarcalSysCliente.Domain.ValueObjects;

namespace VarcalSysCliente.App.Dto
{
    public class ClienteDto
    {
        public int Id { get; set; }
        public string Dominio { get; set; }
        public PessoaTipo PessoaTipo { get; set; }
        public string NomeRazaoSocial { get; set; }
        public string CpfCnpj { get; set; }
        public string RgInscEst { get; set; }
        public string NomeFantasia { get; set; }
        public string NomeResponsavel { get; set; }
        public string Logradouro { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public int UfId { get; set; }
        public string Email { get; set; }
        public string EmailCobranca { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }
        public string Senha { get; set; }
        public string ConfirmaSenha { get; set; }
        public int PlanoHostId { get; set; }
    }
}
