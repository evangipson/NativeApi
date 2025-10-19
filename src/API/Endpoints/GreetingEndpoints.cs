using Application.Constants;
using Domain.Extensions;

namespace API.Endpoints;

/// <summary>
/// A <see langword="static"/> collection of <see langword="static"/> methods that serve as welcoming API endpoints.
/// </summary>
internal static class GreetingEndpoints
{
    internal static string Welcome()
        => GreetingConstants.Greetings.Random();
}
