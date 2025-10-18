namespace Application.Numbers.Services;

/// <summary>
/// Responsible for managing numbers.
/// </summary>
public interface INumberService
{
    /// <summary>
    /// Rolls an <paramref name="amount"/> of dice with any number of <paramref name="sides"/>.
    /// </summary>
    /// <param name="sides">The number of sides of each die.</param>
    /// <param name="amount">The amount of dice to roll.</param>
    /// <returns>The result of the dice roll.</returns>
    int RollDice(int sides, int amount);
}
