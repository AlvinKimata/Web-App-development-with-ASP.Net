using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTestDemo.Services;

namespace TestDemo
{
    [TestClass]
    public class ArithTest
    {
        ArithService arith = new ArithService();

        [DataTestMethod]
        [DataRow(1, 2, 3)]
        [DataRow(2, 2, 4)]
        [DataRow(-1, 4, 3)]
        public void Add(int x, int y, int expected)
        {
            int r = arith.add(x, y);
            Assert.AreEqual(r, expected);
        }

        [DataTestMethod]
        [DataRow(1, 2, -1)]
        [DataRow(2, 2, 0)]
        [DataRow(3, 2, 1)]
        public void Sub(int x, int y, int expected)
        {
            int r = arith.sub(x, y);
            Assert.AreEqual(r, expected);
        }

        [DataTestMethod]
        [DataRow(9, 3, 27)]
        [DataRow(3, 3, 9)]
        [DataRow(-3, -3, 9)]
        [Ignore]
        public void Mul(int x, int y, int expected)
        {
            int r = arith.mul(x, y);
            Assert.AreEqual(r, expected);
        }

        [DataTestMethod]
        [DataRow(9, 3, 3)]
        [DataRow(3, 3, 1)]
        [DataRow(8, 2, 4)]
        [Ignore]
        public void Div(int x, int y, int expected)
        {
            int r = arith.div(x, y);
            Assert.AreEqual(r, expected);
        }
    }
}