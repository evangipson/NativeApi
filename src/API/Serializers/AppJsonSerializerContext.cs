using System.Text.Json.Serialization;
using Domain.Numbers.Requests;
using Microsoft.AspNetCore.Mvc;

namespace API.Serializers;

/// <inheritdoc cref="JsonSerializerContext"/>
[JsonSerializable(typeof(int))]
[JsonSerializable(typeof(RollDiceRequest))]
[JsonSerializable(typeof(AddRequest))]
[JsonSerializable(typeof(ProblemDetails))]
[JsonSerializable(typeof(HttpValidationProblemDetails))]
internal partial class AppJsonSerializerContext : JsonSerializerContext;
