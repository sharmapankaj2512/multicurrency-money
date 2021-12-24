namespace Money.Tests;

public class Franc: Money
{
    public Franc(int amount, string currency): base(amount)
    {
        this.currency = currency;
    }

    public override Money Times(int multiplier)
    {
        return Money.Franc(amount * multiplier);
    }
}