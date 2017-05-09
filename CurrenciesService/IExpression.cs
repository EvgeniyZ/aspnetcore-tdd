namespace CurrenciesService
{
    public interface IExpression 
    {
        Money Reduce(Bank bank, string to);
    }
}