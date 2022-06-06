using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;

namespace Testing
{
    [TestClass]
    public class UnitTestFroddo
    {
        [TestMethod]
        public void ValidaStringQueNoContengaCaracter_Should_ReturnTrue()
        {
            //Arrange 
            string textoAParsear = "6";
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
            Pedido pedido = new Pedido();
            int nroMesa = 0;
            string expected = "-";
            string actual;

            //Act
            actual = pedido.RetornarNroMesa(nroMesa);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    
        [TestMethod]
        public void EnvioCantidadNumerica_Should_RetornarCantidadEscrito()
        {
            //Arrange. 
            Pedido pedido = new Pedido();
            string tipo = "Helado";
            int cantidad = 1;
            string expected = "Un Kilo(1)";
            string actual;

            //Act
            actual = pedido.RetornarCantidadEscrito(tipo, cantidad);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
