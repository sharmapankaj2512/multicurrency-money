namespace Money.Tests;

public class Dollar : Money
{
    private string currency;

    public Dollar(int amount) : base(amount)
    {
        currency = "USD";
    }

    public override Money Times(int multiplier)
    {
        return new Dollar(amount * multiplier);
    }

    public override string Currency()
    {
        return currency;
    }
}