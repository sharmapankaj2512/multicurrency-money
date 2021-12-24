namespace Money.Tests;

public class Money
{
    protected readonly int amount;

    public int Amount => amount;

    protected Money(int amount)
    {
        this.amount = amount;
    }

    public override bool Equals(object? obj)
    {
        return amount == (obj as Money).Amount;
    }

    public override int GetHashCode()
    {
        return Amount;
    }
}

public class Dollar : Money
{
    public Dollar(int amount) : base(amount)
    {
    }

    public Dollar Times(int multiplier)
    {
        return new Dollar(amount * multiplier);
    }
}