using Application;

namespace Application.Numbers.Services;

/// <inheritdoc cref="INumberService"/>
public class NumberService : INumberService
{
    public int RollDice(int sides, int amount)
        => Enumerable.Range(0, amount).Sum(_ => Random.Shared.Next(1, sides + 1));
}
