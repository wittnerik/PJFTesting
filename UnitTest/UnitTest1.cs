using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Arrange
            var calculator = new TestLibrary.Class1();

            //Act
            var vysledok = calculator.Scitaj(3, 5);

            //Assert
            Assert.AreEqual(vysledok, 8);

        }
    }
}
