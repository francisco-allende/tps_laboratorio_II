using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;
using System.Collections.Generic;

namespace Testing
{
    [TestClass]
    public class UnitTestFroddo
    {
        [TestMethod]
        public void ValidaStringQueNoContengaNumeros_Should_ReturnTrue()
        {
            //Arrange 
            string textoAParsear = "Fermin";
            bool expected = true; 
            bool actual;

            //Act
            actual = Validator.NoContieneNumeros(textoAParsear);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void EnvioNroMesaVacioCero_Should_RetornarGuionMedio()
        {
            //Arrange 
            List<int> listaPedidosCliente1 = new List<int>();
            Cliente cliente1 = new Cliente(12000, "Gerado", listaPedidosCliente1, "Se lo lleva", 0, 800);
            Pedido pedido1 = new Pedido(1234, cliente1, "Helado", "Vainilla", 1, 800);

            string expected = "-";
            string actual;

            //Act
            actual = pedido1.RetornarNroMesa(pedido1.ClienteQuePide.NroMesa);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void EnvioCantidadNumerica_Should_RetornarCantidadEscrito()
        {
            //Arrange. 
            List<int> listaPedidosCliente1 = new List<int>();
            Cliente cliente1 = new Cliente(12000, "Gerado", listaPedidosCliente1, "Se lo lleva", 0, 800);
            Pedido pedido1 = new Pedido(1234, cliente1, "Helado", "Vainilla", 1, 800);

            string expected = "Un Kilo (1)";
            string actual;

            //Act
            actual = pedido1.RetornarCantidadEscrito(pedido1.Tipo, pedido1.Cantidad);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
