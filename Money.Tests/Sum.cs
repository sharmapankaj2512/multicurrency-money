namespace Money.Tests;

public class Sum : IExpression
{
    private readonly Money _augend;
    private readonly Money _addend;

    public Sum(Money augend, Money addend)
    {
        _augend = augend;
        _addend = addend;
    }

    public Money Reduce(Bank bank, string to)
    {
        return new Money(_augend._amount + _addend._amount, to);
    }
}