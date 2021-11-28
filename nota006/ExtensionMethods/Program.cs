using ExtensionMethods.Extensions;
using Microsoft.Extensions.Configuration;

var builder = new ConfigurationBuilder();
var config = builder.AddStandardProviders().Build();
System.Console.WriteLine(config.Providers.Count());
System.Console.WriteLine(config.IsLoaded());

