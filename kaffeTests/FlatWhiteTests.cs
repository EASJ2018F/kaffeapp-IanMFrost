using System;
using kaffe;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace kaffeTests
{
    [TestClass]
    public class FlatWhiteTests
    {
        [TestMethod]
        public void TestStyrkeIFlateWhite()
        {
            // arrange
            var fw = new FlatWhite();

            // act

            string styrke = fw.Styrke();

            //Assert

            Assert.AreEqual("Mild",styrke);

        }

        [TestMethod]
        public void TestPrisForFlatWhite()
        {
            // arrange
            var fw = new FlatWhite();

            // act
            int pris = fw.Pris();

            // Assert

            Assert.AreEqual(45,pris);

        }

    }
}

