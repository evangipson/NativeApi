namespace Application.Greetings.Factories;

/// <summary>
/// Responsible for creating welcoming messages.
/// </summary>
public interface IGreetingFactory
{
    /// <summary>
    /// Creates a welcoming greeting message.
    /// </summary>
    /// <returns>The greeting message.</returns>
    string CreateGreeting();
}
