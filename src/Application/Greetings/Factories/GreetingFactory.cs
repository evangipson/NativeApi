using Domain.Extensions;

namespace Application.Greetings.Factories;

/// <inheritdoc cref="IGreetingFactory"/>
public class GreetingFactory : IGreetingFactory
{
    private static readonly List<string> _greetings =
    [
        "Hello!",
        "How do you do?",
        "Hey!",
        "Good to see you.",
        "How's it going?",
        "How are you?",
        "Long time no see!",
        "'Sup?",
        "What's up?",
        "How are you today?",
        "It’s a pleasure to meet you."
    ];

    public string CreateGreeting() => _greetings.Random();
}
