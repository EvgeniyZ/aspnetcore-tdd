using System;
using CurrenciesService;
using Xunit;

namespace CurrenciesTests
{
    public class MoneyTests
    {
        [Fact]
        public void TestMoneyMultiplication()
        {
            var five = Money.Dollar(5);
            Assert.Equal(Money.Dollar(10), five.Times(2));
            Assert.Equal(Money.Dollar(15), five.Times(3));
            Assert.NotEqual(Money.Franc(20), five.Times(4));
            Assert.NotEqual(Money.Ruble(100), five.Times(4));
        }

        [Fact]
        public void TestMoneyEquality()
        {
            Assert.Equal(Money.Dollar(5), Money.Dollar(5));
            Assert.NotEqual(Money.Dollar(5), Money.Dollar(6));
            Assert.False(Money.Dollar(5).Equals(Money.Franc(5)));
        }

        [Fact]
        public void TestSimpleSum()
        {
            var sum = new Sum(Money.Dollar(55), Money.Dollar(45));
            var bank = new Bank();
            var reduced = bank.Reduce(sum, "USD");
            Assert.Equal(Money.Dollar(100), reduced);
        }

        [Fact]
        public void TestBankReduce()
        {
            var bank = new Bank();
            var reduced = bank.Reduce(Money.Dollar(100), "USD");
            Assert.Equal(Money.Dollar(100), reduced);
        }

        [Fact]
        public void TestMultipleCurrenciesSum()
        {
            var bank = new Bank();
            bank.AddRate("CHF", "USD", 2);
            var result = bank.Reduce(Money.Franc(2), "USD");
            Assert.Equal(Money.Dollar(1), result);


            // var sum = new Sum(Money.Dollar(25), Money.Franc(30));
            // result = sum.Reduce(bank, "USD");
            // Assert.Equal(Money.Dollar(40), result);
        }

        [Fact]
        public void TestBankRateIdentity() 
        {
            Assert.Equal(1, new Bank().GetRate("USD", "USD"));
        }
    }
}
