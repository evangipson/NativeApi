using Scalar.AspNetCore;
using API.Endpoints;

namespace API.Extensions;

/// <summary>
/// An <see langword="extension"/> block for extending <see cref="WebApplication"/> functionality.
/// </summary>
internal static class WebApplicationExtensions
{
    extension(WebApplication app)
    {
        /// <summary>
        /// Maps all of the API endpoints to the <see cref="WebApplication"/>.
        /// </summary>
        /// <returns>The <see cref="WebApplication"/>.</returns>
        internal WebApplication MapApiEndpoints()
        {
            app.MapGet("/welcome", GreetingEndpoints.Welcome)
                .WithTags("Greetings")
                .WithDescription("Displays a welcoming message.")
                .ProducesProblem(StatusCodes.Status500InternalServerError)
                .Stable();
            
            app.MapPost("/numbers/add", NumberEndpoints.Add)
                .WithTags("Numbers")
                .WithDescription("Returns the sum of two numbers.")
                .ProducesProblem(StatusCodes.Status400BadRequest)
                .ProducesProblem(StatusCodes.Status500InternalServerError)
                .ProducesValidationProblem(StatusCodes.Status422UnprocessableEntity)
                .Stable();

            app.MapPost("/numbers/rolldice", NumberEndpoints.Roll)
                .WithTags("Numbers")
                .WithDescription("Returns the result of rolling one or many N-sided die.")
                .ProducesProblem(StatusCodes.Status400BadRequest)
                .ProducesProblem(StatusCodes.Status500InternalServerError)
                .ProducesValidationProblem(StatusCodes.Status422UnprocessableEntity)
                .Stable();

            return app;
        }

        /// <summary>
        /// Adds all the necessary Open API mapping and enables Scalar UI.
        /// </summary>
        internal void UseOpenApi()
        {
            app.MapOpenApi();

            app.MapScalarApiReference(options =>
            {
                options.HideClientButton = true;
                options.HideModels = true;
            });
        }
    }
}
