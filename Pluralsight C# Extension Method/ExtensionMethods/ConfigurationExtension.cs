using Microsoft.Extensions.Configuration;

namespace ExtensionMethods.Extensions
{
    public static class ConfigurationExtension
    {
        public static bool IsLoaded(this IConfiguration config)
        {
            return config != null && config.AsEnumerable().Any();
        }

        public static IConfigurationBuilder AddStandardProviders(this IConfigurationBuilder configurationBuilder)
        {
            return configurationBuilder
                                    .AddJsonFile("appsettings.json", optional: true)
                                    .AddEnvironmentVariables()
                                    .AddJsonFile("config/config.json", optional: true)
                                    .AddJsonFile("secrets/secrets.json", optional: true);
        }
    }
}