using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using VarcalSysCliente.Domain.Entities;
using VarcalSysCliente.Domain.ValueObjects;

namespace VarcalSysCliente.Web.Models
{
    public class ClienteViewModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Campo obrigatório")]
        public string Dominio { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [Display(Name = "Pessoa Tipo")]
        public PessoaTipo PessoaTipo { get; set; }
       
        [Required(ErrorMessage = "Campo obrigatório")]
        [Display(Name = "Nome/Razão Social")]
        public string NomeRazaoSocial { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [Display(Name = "CPF/CNPJ")]
        public string CpfCnpj { get; set; }

        [Display(Name = "RG/Insc. Est.")]
        public string RgInscEst { get; set; }

         [Display(Name = "Nome Fantasia")]
        public string NomeFantasia { get; set; }

        [Display(Name = "Nome do Responsável")]
        public string NomeResponsavel { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        public string Logradouro { get; set; }

        public string Bairro { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        public string Cidade { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        public Uf Uf { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [Display(Name = "Email Cobrança")]
        public string EmailCobranca { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        public string Telefone { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        public string Celular { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        public string Senha { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        public string ConfirmaSenha { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [Display(Name = "Plano Host")]
        public int PlanoHostId { get; set; }

    }
}