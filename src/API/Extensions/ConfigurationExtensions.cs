namespace API.Extensions;

/// <summary>
/// An <see langword="extension"/> block for extending <see cref="IConfiguration"/> functionality.
/// </summary>
internal static class ConfigurationExtensions
{
    extension(IConfiguration configuration)
    {
        /// <summary>
        /// The current <see cref="IConfiguration"/> http port.
        /// <para>Uses the <c>ASPNETCORE_HTTP_PORTS</c> environment variable by default.</para>
        /// </summary>
        public int HttpPort => int.TryParse(configuration["ASPNETCORE_HTTP_PORTS"], out var port)
            ? port
            : throw new ApplicationException("Server http port could not be determined. Check the launchSettings.json file.");

        /// <summary>
        /// The current <see cref="IConfiguration"/> https port.
        /// <para>Uses the <c>ASPNETCORE_HTTPS_PORTS</c> environment variable by default.</para>
        /// </summary>
        public int HttpsPort => int.TryParse(configuration["ASPNETCORE_HTTPS_PORTS"], out var port)
            ? port
            : throw new ApplicationException("Server https port could not be determined. Check the launchSettings.json file.");
    }
}
