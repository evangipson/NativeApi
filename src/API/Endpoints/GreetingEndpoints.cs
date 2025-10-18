using Application.Greetings.Factories;
using Microsoft.AspNetCore.Mvc;

namespace API.Endpoints;

/// <summary>
/// A <see langword="static"/> collection of <see langword="static"/> methods that serve as welcoming API endpoints.
/// </summary>
internal static class GreetingEndpoints
{
    internal static string Welcome([FromServices] IGreetingFactory greetingFactory)
        => greetingFactory.CreateGreeting();
}
