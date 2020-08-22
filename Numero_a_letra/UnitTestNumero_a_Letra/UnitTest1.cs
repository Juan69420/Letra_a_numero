using Microsoft.VisualStudio.TestTools.UnitTesting;
using Numero_a_letra.Controllers;

namespace UnitTestNumero_a_Letra
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestLiteral()
        {
            LiteralController literalController = new LiteralController();
            int val = 0;
            string esperado = "CERO";

            string resultado = literalController.Literalget(val);

            Assert.AreEqual(esperado, resultado);
        }
    }
}
