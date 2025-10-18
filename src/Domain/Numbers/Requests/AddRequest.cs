namespace Domain.Numbers.Requests;

/// <summary>
/// A request that contains two numbers to add.
/// </summary>
/// <param name="FirstNumber">The first number to add.</param>
/// <param name="SecondNumber">The second number to add.</param>
public record AddRequest(int FirstNumber, int SecondNumber);