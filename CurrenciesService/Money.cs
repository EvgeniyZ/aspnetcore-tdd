using System;

namespace CurrenciesService
{
    public class Money : IExpression
    {
        public int Amount;
        private string Currency { get; }
        public Money(int amount, string currency)
        {
            Amount = amount;
            Currency = currency;
        }
        public Money Reduce(string to)
        {
            return this;
        }
        public static Money Dollar(int amount)
        {
            return new Money(amount, "USD");
        }

        public static Money Franc(int amount)
        {
            return new Money(amount, "CHF");
        }

        public Sum Plus(Money money)
        {
            return new Sum(this, money);
        }

        public Money Times(int multiplicator)
        {
            return new Money(Amount * multiplicator, Currency);
        }

        public override bool Equals(object obj)
        {
            var money = obj as Money;
            if (money == null)
            {
                return false;
            }
            return Amount == money.Amount && Currency == money.Currency;
        }

        // override object.GetHashCode
        public override int GetHashCode()
        {
            // TODO: write your implementation of GetHashCode() here
            throw new System.NotImplementedException();
        }
    }
}