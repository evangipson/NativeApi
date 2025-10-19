using Microsoft.Extensions.DependencyInjection;
using Application.Numbers.Services;

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
            .AddSingleton<INumberService, NumberService>();
    }
}
