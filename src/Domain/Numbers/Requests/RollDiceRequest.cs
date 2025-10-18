namespace Domain.Numbers.Requests;

/// <summary>
/// A request that contains dice rolling information.
/// </summary>
/// <param name="Sides">The amount of sides each die has.</param>
/// <param name="Amount">The amount of dice to roll.</param>
public record RollDiceRequest(int Sides, int Amount);