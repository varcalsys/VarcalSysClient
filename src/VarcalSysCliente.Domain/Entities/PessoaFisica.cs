using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using BM.Validations;
using VarcalSysCliente.Domain.Contracts;
using VarcalSysCliente.Domain.ValueObjects;

namespace VarcalSysCliente.Domain.Entities
{
    public sealed class PessoaFisica
    {
        public int Id { get; set; }
        public string Nome { get; private set; }
        public string Cpf { get; private set; }
        public string Rg { get; private set; }

        public Cliente Cliente { get; set; }


        protected PessoaFisica()
        {
            
        }

        public PessoaFisica(PlanoHost planoHost, string dominio, string nome, string cpf, PessoaTipo clienteTipo, Endereco endereco, Contato contato,[Optional] string rg)
        {

            ValidatorHelper.GarantirValorPreenchido(nome, "Nome é obrigatório");
            ValidatorHelper.GarantirValorPreenchido(cpf, "Cpf é obrigatório");
            ValidatorHelper.GarantirValorPreenchido(endereco.Logradouro, "Logradouro é obrigatório");
            ValidatorHelper.GarantirValorPreenchido(endereco.Cidade, "Cidade é obrigatório");
            ValidatorHelper.GarantirValorPreenchido(nome, "Nome é obrigatório");
            ValidatorHelper.GarantirIgual(clienteTipo, PessoaTipo.Fisica, "Tipo Pessoa é obrigatório");
            ValidatorHelper.GarantirMaiorQue((int) endereco.Uf, 0, "Uf é obrigatório");
            ValidatorHelper.GarantirValorPreenchido(contato.Email, "Email é obrigatório");
            ValidatorHelper.GarantirValorPreenchido(contato.EmailCobranca, "Email Cobrança é obrigatório");
            ValidatorHelper.GarantirValorPreenchido(contato.Telefone, "Telefone é obrigatório");
            ValidatorHelper.GarantirValorPreenchido(contato.Celular, "Celular é obrigatório");
           
            Nome = nome;
            Cpf = cpf;
            Rg = rg;
            Cliente = new Cliente(dominio, planoHost);
            Cliente.SetClienteTipo(clienteTipo);
            Cliente.SetEndereco(endereco);
            Cliente.SetContato(contato);

        }      
    }
}
