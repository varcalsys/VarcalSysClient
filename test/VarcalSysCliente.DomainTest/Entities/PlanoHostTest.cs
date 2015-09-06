using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VarcalSysCliente.Domain.Entities;

namespace VarcalSysCliente.DomainTest.Entities
{
    [TestClass]
    public class PlanoHostTest
    {
        [TestMethod]
        public void QuandoEuCriarPlanoHost()
        {
            //Arrange
            string descricao = "Plano Host";
            decimal valor = 24.99M;


            //Act
            var planoHost = new PlanoHost(descricao, valor);


            //Assert
            Assert.IsNotNull(planoHost);
            Assert.AreEqual(descricao, planoHost.Descricao);
            Assert.AreEqual(valor, planoHost.Valor);
        }


        [TestMethod]
        [ExpectedException(typeof(ApplicationException))]
        public void QuandoEuCriarPlanoHostDescricaoDeveSerObrigatoria()
        {
            //Arrange
            string descricao = string.Empty;
            decimal valor = 24.99M;


            //Act
            var planoHost = new PlanoHost(descricao, valor);

            //Assert
         
        }

        [TestMethod]
        [ExpectedException(typeof(ApplicationException))]
        public void QuandoEuCriarPlanoHostValorDeveSerObrigatoria()
        {
            //Arrange
            string descricao = "PlanoHost";
            decimal valor = 0;


            //Act
            var planoHost = new PlanoHost(descricao, valor);

            //Assert

        }
    }   
}
