using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;
using Microsoft.Extensions.Configuration.EnvironmentVariables;

namespace Org.Extensions.Environment
{
    public static class ConfigurationExtensions
    {
        /// <summary>
        ///     Verifica se una configurazione è stata caricata
        /// </summary>
        /// <param name="config">configurazione</param>
        /// <returns>True se una configurazione è stata caricata</returns>
        public static bool IsLoaded(this IConfiguration config)
        {
            return config != null && config.AsEnumerable().Any();
        }

        /// <summary>
        ///     Aggiunge i provider standard di configurazione
        /// </summary>
        /// <param name="configurationBuilder">Configuration builder</param>
        /// <returns>Configuration builder</returns>
        public static IConfigurationBuilder AddStandardProviders(this IConfigurationBuilder configurationBuilder)
        {
            return configurationBuilder.AddJsonFile("appsettings.json")
                                       .AddEnvironmentVariables()
                                       .AddJsonFile("config/config.json", optional: true)
                                       .AddJsonFile("secrets/secrtes.json", optional : true);
        }

    }   
}