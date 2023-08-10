
using UnitTest1;

namespace TesProject
{
    /*
    AAA

    Arrange -> Inicializamos las variables
    Act -> Llamamos al método a testear
    Assert - > Verificamos el resultado.
    */

    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ATestSuma()
        {
            //Arrange
            var operador1 = 10; ///set manual (pero esto se puede automatizar)
            var operador2 = 11;

            //Act
            var result = ProcesadorMatematico.Sumar(operador1, operador2);

            //Assert
            var ValorEsperado = 21;

            Assert.AreEqual(ValorEsperado, result);

        }

        [TestMethod]
        public void BTestSumaPositivaConError()
        {
            //Arrange
            var operador1 = 10; ///set manual (pero esto se puede automatizar)
            var operador2 = 20;

            //Act
            var result = ProcesadorMatematico.Sumar(operador1, operador2);

            //Assert
            bool positivo = false;

            if(result > 0)
            {
                positivo = true;
            }

            Assert.IsTrue(positivo);

        }

        [TestMethod]
        public void CTestSumaPositivaSinError()
        {
            //Arrange
            var operador1 = 10; ///set manual (pero esto se puede automatizar)
            var operador2 = -20;

            //Act
            var result = ProcesadorMatematico.Sumar(operador1, operador2);

            //Assert
            bool positivo = false;

            if (result > 0)
            {
                positivo = true;
            }

            Assert.IsTrue(positivo);

        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void DTestDivisionExcepcion()
        {

            //Arrange
            var dividendo = 10;
            var divisor = 10;

            //Act
            var result = ProcesadorMatematico.Division(dividendo, divisor);

            //Assert
            //En este caso, no deberiamos llegar aqui, la prueba correcta es una excepción de DivisionEntreCero

        }

    }
}