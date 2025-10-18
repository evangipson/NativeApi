using API.Serializers;
using Application;

namespace API.Extensions;

/// <summary>
/// An <see langword="extension"/> block for extending <see cref="IServiceCollection"/> functionality.
/// </summary>
internal static class ServiceCollectionExtensions
{
    extension(IServiceCollection services)
    {
        /// <summary>
        /// Adds all the necessary API services to the service collection.
        /// </summary>
        /// <returns>The <see cref="IServiceCollection"/>.</returns>
        internal IServiceCollection AddApiServices() => services
            .ConfigureHttpJsonOptions(options => options.SerializerOptions.TypeInfoResolverChain.Insert(0, AppJsonSerializerContext.Default))
            .AddApplicationServices()
            .AddLogging()
            .AddOpenApi();
    }
}