using Application.Numbers.Services;
using Domain.Numbers.Requests;
using Microsoft.AspNetCore.Mvc;

namespace API.Endpoints;

/// <summary>
/// A <see langword="static"/> collection of <see langword="static"/> methods that serve as number API endpoints.
/// </summary>
internal static class NumberEndpoints
{
    internal static int Add([FromBody] AddRequest request)
        => request.FirstNumber + request.SecondNumber;

    internal static int Roll([FromServices] INumberService numberService, [FromBody] RollDiceRequest request)
        => numberService.RollDice(request.Sides, request.Amount);
}
