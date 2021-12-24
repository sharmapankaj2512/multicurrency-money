namespace Money.Tests;

public class Dollar : Money
{
    public Dollar(int amount, string currency) : base(amount)
    {
        this.currency = currency;
    }

    public override Money Times(int multiplier)
    {
        return new Dollar(amount * multiplier, currency = "USD");
    }
}