namespace Money.Tests;

public class Bank
{
    public Money Reduce(IExpression expr, string to)
    {
        return expr.Reduce(to);
    }

    public void AddRate(string from, string to, int rate)
    {
        
    }
}