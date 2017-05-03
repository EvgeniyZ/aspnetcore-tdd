using System;
using CurrenciesService;
using Xunit;

namespace CurrenciesTests
{
    public class UnitTest1
    {
        [Fact]
        public void TestDollarMultiplication()
        {
            var five = new Dollar(5);
            Assert.Equal(new Dollar(10), five.Times(2));
            Assert.Equal(new Dollar(15), five.Times(3));
        }

        [Fact]
        public void TestDollarEquality()
        {
            Assert.Equal(new Dollar(5), new Dollar(5));
            Assert.NotEqual(new Dollar(5), new Dollar(6));
        }

        [Fact]
        public void TestFrancMultiplication()
        {
            var five = new Franc(5);
            Assert.Equal(new Franc(10), five.Times(2));
            Assert.Equal(new Franc(15), five.Times(3));
        }

        [Fact]
        public void TestFrancEquality()
        {
            Assert.Equal(new Franc(5), new Franc(5));
            Assert.NotEqual(new Franc(5), new Franc(6));
        }
    }
}
