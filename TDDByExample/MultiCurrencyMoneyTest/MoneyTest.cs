using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MultiCurrencyMoneyTest
{
    [TestClass]
    public class MoneyTest
    {
        [TestMethod]
        public void TestMultiplication()
        {
            Dollor five = new Dollar(5);
            five.Times(2);
            Assert.AreEqual(10);
        }
    }
}
