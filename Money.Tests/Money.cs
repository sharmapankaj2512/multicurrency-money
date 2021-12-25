namespace Money.Tests;

public class Money
{
    private readonly int _amount;
    private readonly string _currency;

    private Money(int amount, string currency)
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

    public Money Plus(Money other)
    {
        throw new System.NotImplementedException();
    }
}