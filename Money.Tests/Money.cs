namespace Money.Tests;

public abstract class Money
{
    protected readonly int amount;

    public int Amount => amount;

    protected Money(int amount)
    {
        this.amount = amount;
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
        return new Dollar(amount);
    }

    public abstract Money Times(int amount);

    public static Money Franc(int amount)
    {
        return new Franc(amount);
    }
}