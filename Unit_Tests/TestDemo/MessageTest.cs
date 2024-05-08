using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTestDemo.Services;

namespace TestDemo
{
    [TestClass]
    public class MessageTest
    {
        private const string Expected1 = "Hello there test!";
        private const string Expected2 = "Good Morning!";

        MessageService message = new MessageService();

        [TestMethod]
        public void Message1()
        {
            var m1 = message.msg1();

            Assert.AreEqual(Expected1, m1);
        }

        [TestMethod]
        public void Message2()
        {
            var m2 = message.msg2();

            Assert.AreEqual(Expected2, m2);
        }
    }
}