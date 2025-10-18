using Microsoft.AspNetCore.Server.Kestrel.Core;

namespace API.Extensions;

/// <summary>
/// An <see langword="extension"/> block for extending <see cref="IWebHostBuilder"/> functionality.
/// </summary>
internal static class WebHostBuilderExtensions
{
    extension(IWebHostBuilder webHost)
    {
        /// <summary>
        /// Adds <c>HTTP/1</c>, <c>HTTP/2</c>, and <c>HTTP/3</c> bindings to the <see cref="IWebHostBuilder"/>.
        /// </summary>
        /// <returns>The <see cref="IWebHostBuilder"/>.</returns>
        internal IWebHostBuilder AddBindings() => webHost.ConfigureKestrel((context, options) =>
        {
            // listen on the http port for HTTP/1
            options.ListenAnyIP(context.Configuration.HttpPort, listenOptions => listenOptions.Protocols = HttpProtocols.Http1);

            // listen on the https port for HTTP/1 (to bind successfully), HTTP/2, and HTTP/3
            options.ListenAnyIP(context.Configuration.HttpsPort, listenOptions =>
            {
                listenOptions.Protocols = HttpProtocols.Http1AndHttp2AndHttp3;
                listenOptions.UseHttps();
            });
        });
    }
}
