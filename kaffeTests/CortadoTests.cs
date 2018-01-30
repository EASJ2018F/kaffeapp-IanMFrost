using System;
using kaffe;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace kaffeTests
{
    [TestClass]
    public class CortadoTests
    {
        [TestMethod]
        public void PrisForCortado()
        {
            // arrange
            var cortado = new Cortado();
            // act
            int pris = cortado.Pris();
            // Assert

            Assert.AreEqual(25, pris);

        }
    }
}
