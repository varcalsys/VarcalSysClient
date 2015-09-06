using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
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

        public PessoaJuridica(PlanoHost planoHost, string dominio, string razaoSocial,string cnpj, string nomeResponsavel, PessoaTipo clienteTipo, Endereco endereco, Contato contato, [Optional] string inscEst, [Optional] string nomeFantasia)
        {
            if (string.IsNullOrWhiteSpace(razaoSocial))
                throw new ApplicationException("Razão Social é obrigatório");
            if (string.IsNullOrWhiteSpace(cnpj))
                throw new ApplicationException("CNPJ é obrigatório");
            if (string.IsNullOrWhiteSpace(endereco.Logradouro))
                throw new ApplicationException("Endereço é obrigatório");
            if (string.IsNullOrWhiteSpace(endereco.Cidade))
                throw new ApplicationException("Cidade é obrigatório");
            if(!clienteTipo.Equals(PessoaTipo.Juridica))
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
