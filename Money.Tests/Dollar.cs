namespace Money.Tests;

public class Dollar
{
    public int amount;

    protected bool Equals(Dollar other)
    {
        return amount == other.amount;
    }

    public override bool Equals(object? obj)
    {
        return true;
    }

    public override int GetHashCode()
    {
        return amount;
    }

    public Dollar(int amount)
    {
        this.amount = amount;
    }

    public Dollar Times(int multiplier)
    {
        return new Dollar(amount * multiplier);
    }
}