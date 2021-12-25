namespace Money.Tests;

public interface IExpression
{
    Money Reduce(Bank bank, string to);
}

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

public class Money : IExpression
{
    public readonly int _amount;
    private readonly string _currency;

    public Money(int amount, string currency)
    {
        _amount = amount;
        _currency = currency;
    }

    public string Currency()
    {
        return _currency;
    }

    public Money Times(int multiplier)
    {
        return new Money(_amount * multiplier, _currency);
    }

    public override bool Equals(object? obj)
    {
        return obj is Money money
               && _amount == money._amount
               && _currency == money._currency;
    }

    public override int GetHashCode()
    {
        return _amount;
    }


    public static Money Dollar(int amount)
    {
        return new Money(amount, "USD");
    }

    public static Money Franc(int amount)
    {
        return new Money(amount, "CHF");
    }

    public IExpression Plus(Money that)
    {
        return new Sum(this, that);
    }

    public Money Reduce(Bank bank, string to)
    {
        var rate = bank.Rate(_currency, to);
        return new Money(_amount / rate, to);
    }
}