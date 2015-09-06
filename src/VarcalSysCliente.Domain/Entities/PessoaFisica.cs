using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
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


        public PessoaFisica(PlanoHost planoHost, string dominio, string nome, string cpf, PessoaTipo clienteTipo, Endereco endereco, Contato contato,[Optional] string rg)
        {

            if (string.IsNullOrWhiteSpace(nome))           
                throw new ApplicationException("Nome é obrigatório");
            if (string.IsNullOrWhiteSpace(cpf))
                throw new ApplicationException("Cpf é obrigatório"); 
            if(string.IsNullOrWhiteSpace(endereco.Logradouro))
                throw new ApplicationException("Endereço é obrigatório");
            if (string.IsNullOrWhiteSpace(endereco.Cidade))
                throw new ApplicationException("Cidade é obrigatório");
            if (!clienteTipo.Equals(PessoaTipo.Fisica))
                throw new ApplicationException("Tipo Pessoa é obrigatório");
            if ((int)endereco.Uf < 1)
                throw new ApplicationException("UF é obrigatório");
            if (string.IsNullOrWhiteSpace(contato.Email))
                throw new ApplicationException("Email é obrigatório");
            if (string.IsNullOrWhiteSpace(contato.EmailCobranca))
                throw new ApplicationException("Email de Cobrança é obrigatório");
            if (string.IsNullOrWhiteSpace(contato.Telefone))
                throw new ApplicationException("Telefone é obrigatório");
            if (string.IsNullOrWhiteSpace(contato.Celular))
                throw new ApplicationException("Celular é obrigatório");
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
