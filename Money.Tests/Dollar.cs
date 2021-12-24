namespace Money.Tests;

public class Dollar : Money
{
    public Dollar(int amount, string currency) : base(amount)
    {
        this.currency = currency;
    }

    public override Money Times(int multiplier)
    {
        return Money.Dollar(amount * multiplier);
    }
}