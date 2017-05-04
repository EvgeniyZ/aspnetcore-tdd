namespace CurrenciesService
{
    public interface IExpression 
    {
        Money Reduce(string to);
    }
}