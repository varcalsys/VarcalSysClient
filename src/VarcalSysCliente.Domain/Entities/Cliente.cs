using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VarcalSysCliente.Domain.Contracts;
using VarcalSysCliente.Domain.ValueObjects;

namespace VarcalSysCliente.Domain.Entities
{
    public sealed class Cliente
    {
        public int Id { get; private set; }
        public string Dominio { get; private set; }
        public PessoaTipo PessoaTipo { get; private set; }
        public int EnderecoId { get; private set; }
        public int ContatoId { get; private set; }
        public int PlanoHostId { get; private set; }
        public Endereco Endereco { get; private set; }
        public Contato Contato { get; private set; }
        public PlanoHost PlanoHost { get; private set; }
        public DateTime DataCadastro { get; private set; }
        public bool Ativo { get; set; }

        public PessoaFisica PessoaFisica { get; private set; }
        public PessoaJuridica PessoaJuridica { get; private set; }

        protected Cliente()
        {
            
        }

        public Cliente(string dominio, PlanoHost planoHost)
        {
            if (string.IsNullOrEmpty(dominio))
                throw new ApplicationException("Dominio é obrigatório");
            if (string.IsNullOrWhiteSpace(planoHost.Descricao))
                throw new ApplicationException("Descrição do Plano Host é obrigatorio");
            if (planoHost.Valor <= 0)
                throw new ApplicationException("Valor do Plano Host é obrigatorio");

            Dominio = dominio;
            PlanoHost = planoHost;
        }


        public void SetDominio(string dominio)
        {
            Dominio = dominio;
        }

        public void SetPlanoHost(PlanoHost planoHost)
        {
            PlanoHost = planoHost;
        }

        public void SetClienteTipo(PessoaTipo clienteTipo)
        {
            PessoaTipo = clienteTipo;
        }

        public void SetEndereco(Endereco endereco)
        {
            Endereco = endereco;
        }

        public void SetContato(Contato contato)
        {
            Contato = contato;
        }       
    }
}
