namespace Money.Tests;

public class Dollar : Money
{
    public Dollar(int amount) : base(amount)
    {
        currency = "USD";
    }

    public override Money Times(int multiplier)
    {
        return new Dollar(amount * multiplier);
    }
}