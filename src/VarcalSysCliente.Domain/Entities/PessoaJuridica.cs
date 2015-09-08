using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using BM.Validations;
using VarcalSysCliente.Domain.ValueObjects;

namespace VarcalSysCliente.Domain.Entities
{
    public sealed class PessoaJuridica
    {

        public int Id { get; set; }
        public string RazaoSocial { get; private set; }
        public string Cnpj { get; private set; }
        public string InscEst { get; private set; }
        public string NomeFantasia { get; private set; }
        public string NomeResponsavel { get; private set; }
        public Cliente Cliente { get; set; }

        protected PessoaJuridica()
        {
            
        }

        public PessoaJuridica(PlanoHost planoHost, string dominio, string razaoSocial,string cnpj, string nomeResponsavel, PessoaTipo clienteTipo, Endereco endereco, Contato contato, [Optional] string inscEst, [Optional] string nomeFantasia)
        {

            ValidatorHelper.GarantirValorPreenchido(razaoSocial, "Razão Social é obrigatório");
            ValidatorHelper.GarantirValorPreenchido(cnpj, "Cnpj é obrigatório");
            ValidatorHelper.GarantirValorPreenchido(endereco.Logradouro, "Logradouro é obrigatório");
            ValidatorHelper.GarantirValorPreenchido(endereco.Cidade, "Cidade é obrigatório");
            ValidatorHelper.GarantirIgual(clienteTipo, PessoaTipo.Juridica, "Tipo Pessoa é obrigatório");
            ValidatorHelper.GarantirMaiorQue((int)endereco.Uf, 0, "Uf é obrigatório");
            ValidatorHelper.GarantirValorPreenchido(contato.Email, "Email é obrigatório");
            ValidatorHelper.GarantirValorPreenchido(contato.EmailCobranca, "Email Cobrança é obrigatório");
            ValidatorHelper.GarantirValorPreenchido(contato.Telefone, "Telefone é obrigatório");
            ValidatorHelper.GarantirValorPreenchido(contato.Celular, "Celular é obrigatório");

            RazaoSocial = razaoSocial;
            Cnpj = cnpj;
            InscEst = inscEst;
            NomeFantasia = nomeFantasia;
            NomeResponsavel = nomeResponsavel;
            Cliente = new Cliente(dominio, planoHost);
            Cliente.SetClienteTipo(clienteTipo);
            Cliente.SetEndereco(endereco);
            Cliente.SetContato(contato);
        }
    }
}
