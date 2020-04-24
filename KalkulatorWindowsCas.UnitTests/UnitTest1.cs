using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using KalkulatorWindowsChas;

namespace KalkulatorWindowsCas.UnitTests
{
    [TestClass]
    public class OperationsTesting
    {
        [TestMethod]
        public void Add_Test()
        {
            decimal broj1 = 20.5M, broj2 = 30;

            decimal result = Operation_Units.Add(broj1, broj2);

            Assert.IsTrue(result == 50.5M);
        }
        [TestMethod]
        public void Substract_Test()
        {
            decimal broj1 = 20.5M, broj2 = 30;

            decimal result = Operation_Units.Substract(broj1, broj2);

            Assert.IsTrue(result == -9.5M);
        }
        [TestMethod]
        public void Multiply_Test()
        {
            decimal broj1 = 20.5M, broj2 = 30;

            decimal result = Operation_Units.Multiply(broj1, broj2);

            Assert.IsTrue(result == 615);
        }
        [TestMethod]
        public void Divide_Test()
        {
            decimal broj1 = 20.5M, broj2 = 20;

            decimal result = Operation_Units.Divide(broj1, broj2);

            Assert.IsTrue(result == 1.025M);
        }
        [TestMethod]
        public void Square_Test()
        {
            decimal broj1 = 8;

            decimal result = Operation_Units.Square(broj1);

            Assert.IsTrue(result == 64);
        }
        [TestMethod]
        public void SquareRoot_Test()
        {
            decimal broj1 = 64;

            decimal result = Operation_Units.SquareRoot(broj1);

            Assert.IsTrue(result == 8);
        }
        [TestMethod]
        public void Reciprocal_Test()
        {
            decimal broj1 = 20;

            decimal result = Operation_Units.Reciprocal(broj1);

            Assert.IsTrue(result == 0.05M);
        }
    }
}
