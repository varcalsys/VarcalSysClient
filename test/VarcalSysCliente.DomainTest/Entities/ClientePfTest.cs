using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VarcalSysCliente.Domain.Entities;
using VarcalSysCliente.Domain.ValueObjects;

namespace VarcalSysCliente.DomainTest.Entities
{
    [TestClass]
    public class ClientePfTest
    {
        string _dominio = "teste.com.br";
        PlanoHost _planoHost = new PlanoHost("Plano Host", 24.99M);

        [TestMethod]
        public void QuandoEuCriarUmCliente()
        {
            //Arrange
            const string nome = "Nome Cliente";
            const string cpf = "00000000000";
            const PessoaTipo clienteTipo = PessoaTipo.Fisica;
            Endereco logradouro = new Endereco
            {
                Logradouro = "Endereço do CLiente",
                Cidade = "São Paulo",
                Uf = Uf.SP,
            };
            Contato contato = new Contato
            {
                Celular = "11922223456",
                Email = "teste@teste.com",
                EmailCobranca = "cobranca@cobranca.com",
                Telefone = "1123456789"
            };

            //Act
            var cliente = new PessoaFisica(_planoHost, _dominio, nome, cpf, clienteTipo, logradouro, contato);

            //Assert
            Assert.IsNotNull(cliente);
            Assert.AreEqual(nome, cliente.Nome);
            Assert.AreEqual(cpf, cliente.Cpf);
            Assert.IsNotNull(cliente.Cliente.Endereco);
            Assert.IsNotNull(cliente.Cliente.Contato);
        }


        [TestMethod]
        [ExpectedException(typeof (ApplicationException))]
        public void QuandoEuCriarUmClienteDominioDeveSerObrigatorio()
        {
            //Arrange
            _dominio = string.Empty;
            const string nome = "Nome Cliente";
            const string cpf = "00000000000";
            const PessoaTipo clienteTipo = PessoaTipo.Fisica;
            Endereco logradouro = new Endereco
            {
                
                Logradouro = "Endereço do CLiente",
                Cidade = "São Paulo",
                Uf = Uf.SP,
            };
            Contato contato = new Contato
            {
                Celular = "11922223456",
                Email = "teste@teste.com",
                EmailCobranca = "cobranca@cobranca.com",
                Telefone = "1123456789"
            };

            //Act
            var cliente = new PessoaFisica(_planoHost, _dominio, nome, cpf, clienteTipo, logradouro, contato);
        }

        [TestMethod]
        [ExpectedException(typeof(ApplicationException))]
        public void QuandoEuCriarUmClientePlanoHostDeveSerObrigatorio()
        {
            //Arrange
            const string nome = "Nome Cliente";
            const string cpf = "00000000000";
            const PessoaTipo clienteTipo = PessoaTipo.Fisica;
            Endereco logradouro = new Endereco
            {
                Logradouro = "Endereço do CLiente",
                Cidade = "São Paulo",
                Uf = Uf.SP,
            };
            Contato contato = new Contato
            {
                Celular = "11922223456",
                Email = "teste@teste.com",
                EmailCobranca = "cobranca@cobranca.com",
                Telefone = "1123456789"
            };

            _planoHost = new PlanoHost("",0);

            //Act
            var cliente = new PessoaFisica(_planoHost, _dominio, nome, cpf, clienteTipo, logradouro, contato);
        }

        [TestMethod]
        [ExpectedException(typeof(ApplicationException))]
        public void QuandoEuCriarUmClienteNomeDeveSerObrigatorio()
        {
            //Arrange
            string nome = string.Empty;
            const string cpf = "00000000000";
            const PessoaTipo clienteTipo = PessoaTipo.Fisica;
            Endereco logradouro = new Endereco();
            Contato contato = new Contato();

            //Act
            var cliente = new PessoaFisica(_planoHost, _dominio, nome, cpf, clienteTipo, logradouro, contato);

            //Assert
        }

        [TestMethod]
        [ExpectedException(typeof(ApplicationException))]
        public void QuandoEuCriarUmClienteCpfDeveSerObrigatorio()
        {
            //Arrange
            const string nome = "Cliente";
            string cpf = string.Empty;
            const PessoaTipo clienteTipo = PessoaTipo.Fisica;
            Endereco logradouro = new Endereco();
            Contato contato = new Contato();

            //Act
            var cliente = new PessoaFisica(_planoHost, _dominio, nome, cpf, clienteTipo, logradouro, contato);

            //Assert
        }

        [TestMethod]
        [ExpectedException(typeof(ApplicationException))]
        public void QuandoEuCriarUmClienteEnderecoDeveSerObrigatorio()
        {
            //Arrange
            const string nome = "Cliente";
            string cpf = string.Empty;
            const PessoaTipo clienteTipo = PessoaTipo.Fisica;
            Endereco logradouro = new Endereco
            {
                Logradouro = string.Empty,
                Cidade = "São Paulo",
                Uf = Uf.SP,
            };
            Contato contato = new Contato();

            //Act
            var cliente = new PessoaFisica(_planoHost, _dominio, nome, cpf, clienteTipo, logradouro, contato);

            //Assert
        }

        [TestMethod]
        [ExpectedException(typeof(ApplicationException))]
        public void QuandoEuCriarUmClienteCidadeDeveSerObrigatorio()
        {
            //Arrange
            const string nome = "Cliente";
            string cpf = string.Empty;
            const PessoaTipo clienteTipo = PessoaTipo.Fisica;
            Endereco logradouro = new Endereco
            {
                Logradouro = "Endereço do Cliente",
                Cidade = string.Empty,
                Uf = Uf.SP,
            };
            Contato contato = new Contato();

            //Act
            var cliente = new PessoaFisica(_planoHost, _dominio, nome, cpf, clienteTipo, logradouro, contato);

            //Assert
        }

        [TestMethod]
        [ExpectedException(typeof(ApplicationException))]
        public void QuandoEuCriarUmUfDeveSerObrigatorio()
        {
            //Arrange
            const string nome = "Cliente";
            string cpf = string.Empty;
            const PessoaTipo clienteTipo = PessoaTipo.Fisica;
            Endereco logradouro = new Endereco
            {
                Logradouro = "Endereço do Cliente",
                Cidade = "São Paulo",
                Uf = 0,
            };
            Contato contato = new Contato();

            //Act
            var cliente = new PessoaFisica(_planoHost, _dominio, nome, cpf, clienteTipo, logradouro, contato);

            //Assert
        }

        [TestMethod]
        [ExpectedException(typeof(ApplicationException))]
        public void QuandoEuCriarUmClienteOEmailDeveSerObrigatorio()
        {
            //Arrange
            const string nome = "Nome Cliente";
            const string cpf = "00000000000";
            const PessoaTipo clienteTipo = PessoaTipo.Fisica;
            Endereco logradouro = new Endereco
            {
                Logradouro = "Endereço do CLiente",
                Cidade = "São Paulo",
                Uf = Uf.SP,
            };
            Contato contato = new Contato();

            //Act
            var cliente = new PessoaFisica(_planoHost, _dominio, nome, cpf, clienteTipo, logradouro, contato);
        }

        [TestMethod]
        [ExpectedException(typeof(ApplicationException))]
        public void QuandoEuCriarUmClienteOEmailCobrancaDeveSerObrigatorio()
        {
            //Arrange
            const string nome = "Nome Cliente";
            const string cpf = "00000000000";
            const PessoaTipo clienteTipo = PessoaTipo.Fisica;
            Endereco logradouro = new Endereco
            {
                Logradouro = "Endereço do CLiente",
                Cidade = "São Paulo",
                Uf = Uf.SP,
            };
            Contato contato = new Contato();

            //Act
            var cliente = new PessoaFisica(_planoHost, _dominio, nome, cpf, clienteTipo, logradouro, contato);
        }

        [TestMethod]
        [ExpectedException(typeof(ApplicationException))]
        public void QuandoEuCriarUmClienteTelefoneDeveSerObrigatorio()
        {
            //Arrange
            const string nome = "Nome Cliente";
            const string cpf = "00000000000";
            const PessoaTipo clienteTipo = PessoaTipo.Fisica;
            Endereco logradouro = new Endereco
            {
                Logradouro = "Endereço do CLiente",
                Cidade = "São Paulo",
                Uf = Uf.SP,
            };
            Contato contato = new Contato();

            //Act
            var cliente = new PessoaFisica(_planoHost, _dominio, nome, cpf, clienteTipo, logradouro, contato);
        }


        [TestMethod]
        [ExpectedException(typeof(ApplicationException))]
        public void QuandoEuCriarUmClienteCelularDeveSerObrigatorio()
        {
            //Arrange
            const string nome = "Nome Cliente";
            const string cpf = "00000000000";
            const PessoaTipo clienteTipo = PessoaTipo.Fisica;
            Endereco logradouro = new Endereco
            {
                Logradouro = "Endereço do CLiente",
                Cidade = "São Paulo",
                Uf = Uf.SP,
            };
            Contato contato = new Contato();

            //Act
            var cliente = new PessoaFisica(_planoHost, _dominio, nome, cpf, clienteTipo, logradouro, contato);
        }

    }
}