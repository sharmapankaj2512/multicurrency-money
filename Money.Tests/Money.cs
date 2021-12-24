namespace Money.Tests;

public class Money
{
    protected readonly int amount;
    protected string currency;

    public int Amount => amount;

    protected Money(int amount, string currency)
    {
        this.amount = amount;
        this.currency = currency;
    }

    public override bool Equals(object? obj)
    {
        if (obj?.GetType() != GetType())
            return false;
        return amount == (obj as Money).Amount;
    }

    public override int GetHashCode()
    {
        return Amount;
    }

    public static Money Dollar(int amount)
    {
        return new Money(amount, "USD");
    }

    public Money Times(int multiplier)
    {
        return new Money(amount * multiplier, "USD");
    }

    public static Money Franc(int amount)
    {
        return new Money(amount, "CHF");
    }

    public string Currency()
    {
        return currency;
    }
}