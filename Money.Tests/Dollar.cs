namespace Money.Tests;

public class Dollar
{
    private readonly int _amount;

    protected bool Equals(Dollar other)
    {
        return _amount == other._amount;
    }

    public override bool Equals(object? obj)
    {
        return _amount == (obj as Dollar)._amount;
    }

    public override int GetHashCode()
    {
        return _amount;
    }

    public Dollar(int amount)
    {
        this._amount = amount;
    }

    public Dollar Times(int multiplier)
    {
        return new Dollar(_amount * multiplier);
    }
}