using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VarcalSysCliente.Domain.Entities;
using VarcalSysCliente.Domain.ValueObjects;

namespace VarcalSysCliente.DomainTest.Entities
{
    [TestClass]
    public class ClientePjTeste
    {
        string dominio = "teste.com.br";
        string nomeResponsavel = "Nome do responsavel";
        PlanoHost _planoHost = new PlanoHost("Plano Host", 24.99M);


        [TestMethod]
        public void QuandoEuCriarUmCliente()
        {
            //Arrange
            const string razaoSocial = "Nome Cliente";
            const string cnpj = "00000000000";
            const PessoaTipo clienteTipo = PessoaTipo.Juridica;
            Endereco endereco = new Endereco("Endereço do Cliente", "São Paulo", Uf.SP);
            Contato contato = new Contato("teste@teste.com", "cobranca@cobranca.com", "1122223456", "11922223456");


            //Act
            var cliente = new PessoaJuridica(_planoHost, dominio, razaoSocial, cnpj, nomeResponsavel, clienteTipo, endereco, contato);

            //Assert
            Assert.IsNotNull(cliente);
            Assert.AreEqual(razaoSocial, cliente.RazaoSocial);
            Assert.AreEqual(cnpj, cliente.Cnpj);
            Assert.AreEqual(nomeResponsavel, cliente.NomeResponsavel);
            Assert.IsNotNull(cliente.Cliente.Endereco);
            Assert.IsNotNull(cliente.Cliente.Contato);
        }


        [TestMethod]
        [ExpectedException(typeof(ApplicationException))]
        public void QuandoEuCriarUmClienteDominioDeveSerObrigatorio()
        {
            //Arrange
            dominio = string.Empty;
            const string razaoSocial = "Nome Cliente";
            const string cnpj = "00000000000";
            const PessoaTipo clienteTipo = PessoaTipo.Fisica;
            Endereco endereco = new Endereco("Endereço do Cliente", "São Paulo", Uf.SP);
            Contato contato = new Contato("teste@teste.com", "cobranca@cobranca.com", "1122223456", "11922223456");


            //Act
            var cliente = new PessoaJuridica(_planoHost, dominio, razaoSocial, cnpj, nomeResponsavel, clienteTipo, endereco, contato);
        }


        [TestMethod]
        [ExpectedException(typeof(ApplicationException))]
        public void QuandoEuCriarUmClientePlanoHostDeveSerObrigatorio()
        {
            //Arrange
            const string razaoSocial = "Nome Cliente";
            const string cnpj = "00000000000";
            const PessoaTipo clienteTipo = PessoaTipo.Fisica;
            Endereco endereco = new Endereco("Endereço do Cliente", "São Paulo", Uf.SP);
            Contato contato = new Contato("teste@teste.com", "cobranca@cobranca.com", "1122223456", "11922223456");


            _planoHost = new PlanoHost("", 0);

            //Act
            var cliente = new PessoaJuridica(_planoHost, dominio, razaoSocial, cnpj, nomeResponsavel, clienteTipo, endereco, contato);
        }


        [TestMethod]
        [ExpectedException(typeof(ApplicationException))]
        public void QuandoEuCriarUmClienteRazaoSocialDeveSerObrigatorio()
        {
            //Arrange
            string razaoSocial = string.Empty;
            const string cnpj = "00000000000";
            const PessoaTipo clienteTipo = PessoaTipo.Fisica;
            Endereco endereco = new Endereco("Endereço do Cliente", "São Paulo", Uf.SP);
            Contato contato = new Contato("teste@teste.com", "cobranca@cobranca.com", "1122223456", "11922223456");

            //Act
            var cliente = new PessoaJuridica(_planoHost, dominio, razaoSocial, cnpj, nomeResponsavel, clienteTipo, endereco, contato);
        
            //Assert
        }

        [TestMethod]
        [ExpectedException(typeof(ApplicationException))]
        public void QuandoEuCriarUmClienteCnpjDeveSerObrigatorio()
        {
            //Arrange
            const string razaoSocial = "Cliente";
            string cnpj = string.Empty;
            const PessoaTipo clienteTipo = PessoaTipo.Fisica;
            Endereco endereco = new Endereco("Endereço do Cliente", "São Paulo", Uf.SP);
            Contato contato = new Contato("teste@teste.com", "cobranca@cobranca.com", "1122223456", "11922223456");


            //Act
            var cliente = new PessoaJuridica(_planoHost, dominio, razaoSocial, cnpj, nomeResponsavel, clienteTipo, endereco, contato);

            //Assert
        }

        [TestMethod]
        [ExpectedException(typeof(ApplicationException))]
        public void QuandoEuCriarUmClienteLogradouroDeveSerObrigatorio()
        {
            //Arrange
            const string razaoSocial = "Cliente";
            string cnpj = string.Empty;
            const PessoaTipo clienteTipo = PessoaTipo.Fisica;
            Endereco endereco = new Endereco("", "São Paulo", Uf.SP);
            Contato contato = new Contato("teste@teste.com", "cobranca@cobranca.com", "1122223456", "11922223456");


            //Act
            var cliente = new PessoaJuridica(_planoHost, dominio, razaoSocial, cnpj, nomeResponsavel, clienteTipo, endereco, contato);

            //Assert
        }

        [TestMethod]
        [ExpectedException(typeof(ApplicationException))]
        public void QuandoEuCriarUmClienteCidadeDeveSerObrigatorio()
        {
            //Arrange
            const string razaoSocial = "Cliente";
            string cnpj = string.Empty;
            const PessoaTipo clienteTipo = PessoaTipo.Fisica;
            Endereco endereco = new Endereco("Endereço do Cliente", "", Uf.SP);
            Contato contato = new Contato("teste@teste.com", "cobranca@cobranca.com", "1122223456", "11922223456");


            //Act
            var cliente = new PessoaJuridica(_planoHost, dominio, razaoSocial, cnpj, nomeResponsavel, clienteTipo, endereco, contato);

            //Assert
        }

        [TestMethod]
        [ExpectedException(typeof(ApplicationException))]
        public void QuandoEuCriarUmUfDeveSerObrigatorio()
        {
            //Arrange
            const string razaoSocial = "Cliente";
            string cnpj = string.Empty;
            const PessoaTipo clienteTipo = PessoaTipo.Fisica;
            Endereco endereco = new Endereco("Endereço do Cliente", "São Paulo", 0);
            Contato contato = new Contato("teste@teste.com", "cobranca@cobranca.com", "1122223456", "11922223456");


            //Act
            var cliente = new PessoaJuridica(_planoHost, dominio, razaoSocial, cnpj, nomeResponsavel, clienteTipo, endereco, contato);

            //Assert
        }

        [TestMethod]
        [ExpectedException(typeof(ApplicationException))]
        public void QuandoEuCriarUmClienteOEmailDeveSerObrigatorio()
        {
            //Arrange
            const string razaoSocial = "Nome Cliente";
            const string cnpj = "00000000000";
            const PessoaTipo clienteTipo = PessoaTipo.Fisica;
            Endereco endereco = new Endereco("Endereço do Cliente", "São Paulo", Uf.SP);
            Contato contato = new Contato("", "cobranca@cobranca.com", "1122223456", "11922223456");


            //Act
            var cliente = new PessoaJuridica(_planoHost, dominio, razaoSocial, cnpj, nomeResponsavel, clienteTipo, endereco, contato);
        }

        [TestMethod]
        [ExpectedException(typeof(ApplicationException))]
        public void QuandoEuCriarUmClienteOEmailCobrancaDeveSerObrigatorio()
        {
            //Arrange
            const string razaoSocial = "Nome Cliente";
            const string cnpj = "00000000000";
            const PessoaTipo clienteTipo = PessoaTipo.Fisica;
            Endereco endereco = new Endereco("Endereço do Cliente", "São Paulo", Uf.SP);
            Contato contato = new Contato("teste@teste.com", "", "1122223456", "11922223456");


            //Act
            var cliente = new PessoaJuridica(_planoHost, dominio, razaoSocial, cnpj, nomeResponsavel, clienteTipo, endereco, contato);
        }

        [TestMethod]
        [ExpectedException(typeof(ApplicationException))]
        public void QuandoEuCriarUmClienteTelefoneDeveSerObrigatorio()
        {
            //Arrange
            const string razaoSocial = "Nome Cliente";
            const string cnpj = "00000000000";
            const PessoaTipo clienteTipo = PessoaTipo.Fisica;
            Endereco endereco = new Endereco("Endereço do Cliente", "São Paulo", Uf.SP);
            Contato contato = new Contato("teste@teste.com", "cobranca@cobranca.com", "", "11922223456");


            //Act
            var cliente = new PessoaJuridica(_planoHost, dominio, razaoSocial, cnpj, nomeResponsavel, clienteTipo, endereco, contato);
        }


        [TestMethod]
        [ExpectedException(typeof(ApplicationException))]
        public void QuandoEuCriarUmClienteCelularDeveSerObrigatorio()
        {
            //Arrange
            const string razaoSocial = "Nome Cliente";
            const string cnpj = "00000000000";
            const PessoaTipo clienteTipo = PessoaTipo.Fisica;
            Endereco endereco = new Endereco("Endereço do Cliente", "São Paulo", Uf.SP);
            Contato contato = new Contato("teste@teste.com", "cobranca@cobranca.com", "1122223456", "");


            //Act
            var cliente = new PessoaJuridica(_planoHost, dominio, razaoSocial, cnpj, nomeResponsavel, clienteTipo, endereco, contato);
        }
    }
}
