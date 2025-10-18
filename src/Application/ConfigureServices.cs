using Microsoft.Extensions.DependencyInjection;
using Application.Numbers.Services;
using Application.Greetings.Factories;

namespace Application;

/// <summary>
/// An <see langword="extension"/> block for extending <see cref="IServiceCollection"/> functionality.
/// </summary>
public static class ConfigureServices
{
    extension(IServiceCollection services)
    {
        /// <summary>
        /// Adds all necessary application services to the service collection.
        /// </summary>
        /// <returns>The <see cref="IServiceCollection"/>.</returns>
        public IServiceCollection AddApplicationServices() => services
            .AddSingleton<IGreetingFactory, GreetingFactory>()
            .AddSingleton<INumberService, NumberService>();
    }
}
