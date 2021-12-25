namespace Money.Tests;

public class Bank
{
    public Money Reduce(IExpression expr, string to)
    {
        return expr.Reduce(to);
    }
}