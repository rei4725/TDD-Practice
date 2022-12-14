using Microsoft.VisualStudio.TestTools.UnitTesting;
using MultiCurrencyMoney;
using System;

namespace MultiCurrencyMoneyTest
{
    [TestClass]
    public class MoneyTest
    {
        [TestMethod]
        public void TestMultiplication()
        {
            Money five = Money.Dollar(5);
            Assert.AreEqual(Money.Dollar(10), five.Times(2));
            Assert.AreEqual(Money.Dollar(15), five.Times(3));
        }

        [TestMethod]
        public void TestEquality()
        {
            Assert.IsTrue(Money.Dollar(5).Equals(Money.Dollar(5)));
            Assert.IsFalse(Money.Dollar(5).Equals(null));
            Assert.IsFalse(Money.Dollar(6).Equals(Money.Dollar(5)));
            Assert.IsFalse(Money.Dollar(5).Equals(Money.Franc(5)));
        }
                
        [TestMethod]
        public void TestCurrency()
        {
            Assert.AreEqual(CurrencyID.USD, Money.Dollar(1).Currency());
            Assert.AreEqual(CurrencyID.CHF, Money.Franc(1).Currency());
        }

        [TestMethod]
        public void TestSimpleAddition()
        {
            Money five = Money.Dollar(5);
            Expression sum = five.Plus(five);
            Bank bank = new Bank();
            Money reduced = bank.Reduce(sum, CurrencyID.USD);
            Assert.AreEqual(Money.Dollar(10), reduced);
        }
    }
}
