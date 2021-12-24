namespace Money.Tests;

public class Franc: Money
{
    private string currency;

    public Franc(int amount): base(amount)
    {
        currency = "CHF";
    }

    public override Money Times(int multiplier)
    {
        return new Franc(amount * multiplier);
    }

    public override string Currency()
    {
        return currency;
    }
}