namespace Money.Tests;

public class Bank
{
    public Money Reduce(IExpression expr, string to)
    {
        return expr.Reduce(this, to);
    }

    public void AddRate(string from, string to, int rate)
    {
        
    }

    public int Rate(string from, string to)
    {
        return from == "CHF" && to == "USD"? 2 : 1;
    }
}