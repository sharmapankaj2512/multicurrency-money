using System;
using System.Collections.Generic;

namespace Money.Tests;

public class Bank
{
    private Dictionary<Tuple<string, string>, int> _rates = new();

    public Money Reduce(IExpression expr, string to)
    {
        return expr.Reduce(this, to);
    }

    public void AddRate(string from, string to, int rate)
    {
        _rates[Tuple.Create(from, to)] = rate;
    }

    public int Rate(string from, string to)
    {
        return from == to ? 1 : _rates[Tuple.Create(from, to)];
    }
}