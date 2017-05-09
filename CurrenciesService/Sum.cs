namespace CurrenciesService
{
    public class Sum : IExpression
    {
        public Sum(Money augend, Money addend)
        {
            Augend = augend;
            Addend = addend;
        }
        public Money Augend { get; }
        public Money Addend { get; }
        public Money Reduce(Bank bank, string to)
        {
            return new Money(Augend.Amount + Addend.Amount, to);
        }
    }
}