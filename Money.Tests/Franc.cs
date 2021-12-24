namespace Money.Tests;

public class Franc
{
    private readonly int _amount;

    protected bool Equals(Franc other)
    {
        return _amount == other._amount;
    }

    public override bool Equals(object? obj)
    {
        return _amount == (obj as Franc)._amount;
    }

    public override int GetHashCode()
    {
        return _amount;
    }

    public Franc(int amount)
    {
        this._amount = amount;
    }

    public Franc Times(int multiplier)
    {
        return new Franc(_amount * multiplier);
    }
}