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
        public void RetornaCantidadEscrito_Should_ReturnUnKilo()
        {
            //Arrange 
            Pedido pedido = new Pedido();
            double cantidad = 1;
            string expected = "Un Kilo (1)";
            string actual;

            //Act
            actual = pedido.RetornarCantidadEscrito(cantidad);

            //Assert
            Assert.AreEqual(expected, actual);
        }
        
        [TestMethod]
        public void ValidaQueUnStringNoSeaNroNegativoNiContengaCaracteres_Should_ReturnTrue()
        {
            //Arrange 
            string textoAParsear = "74";
            bool expected = true;
            bool actual;

            //Act
            actual = Validator.NoEsNegativoNiCaracter(textoAParsear);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
