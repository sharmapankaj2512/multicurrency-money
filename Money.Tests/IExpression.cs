namespace Money.Tests;

public interface IExpression
{
    Money Reduce(Bank bank, string to);
}