using Microsoft.Extensions.Configuration;
using System.Text.RegularExpressions;

namespace Microsoft.Maui.Hosting
{
    public static partial class AppBuilderExtensions
    {
        public static MauiAppBuilder ConfigureEnvironmentVariables(this MauiAppBuilder builder)
        {
            var environmentVariables = Environment.GetEnvironmentVariables();

            // Look for Aspire-related environment variables.
            // If none are found, skip the rest of the processing.
            if (environmentVariables["ASPIRE_RESOURCE_SERVICE_ENDPOINT_URL"] is null
                && environmentVariables["ASPIRE_DASHBOARD_OTLP_ENDPOINT_URL"] is null)
            {
                return builder;
            }

#if ANDROID
            const string androidEnvVarFilePath = "/data/local/tmp/ide-launchenv.txt";

            // For Android we read the environment variables from a text file that is written to the device/emulator
            // If the file not exists, we will use the default environment variables which is less stable
            if (OperatingSystem.IsAndroid() && File.Exists(androidEnvVarFilePath))
            {
                var envVarLines = File.ReadAllLines(androidEnvVarFilePath);

                var fileEnvironmentVariables = envVarLines
                    .Select(line => line.Split('=', 2))
                    .ToDictionary(parts => parts[0], parts => parts[1]);

                // Merge file environment variables into the existing environment variables
                foreach (var kvp in fileEnvironmentVariables)
                {
                    environmentVariables[kvp.Key] = kvp.Value;
                }
            }

#endif
            string devTunnelId = environmentVariables["DEVTUNNEL_ID"]?.ToString() ?? string.Empty;

            var variablesToInclude = new HashSet<string>
            {
                "ASPNETCORE_ENVIRONMENT",
                "ASPNETCORE_URLS",
                "DOTNET_ENVIRONMENT",
                "DOTNET_LAUNCH_PROFILE",
                "DOTNET_SYSTEM_CONSOLE_ALLOW_ANSI_COLOR_REDIRECTION"
            };

            var prefixesToRemove = new List<string>
            {
                "ASPNETCORE_",
                "DOTNET_",
            };

            List<KeyValuePair<string, string?>> settings = [];

            foreach (object variableNameObject in environmentVariables.Keys)
            {
                string variableName = (string)variableNameObject;
                if (variablesToInclude.Contains(variableName)
                    || variableName.StartsWith("OTEL_", StringComparison.OrdinalIgnoreCase)
                    || variableName.StartsWith("LOGGING__CONSOLE", StringComparison.OrdinalIgnoreCase)
                    || variableName.StartsWith("services__", StringComparison.OrdinalIgnoreCase))
                {
                    string value = (string)environmentVariables[variableName]!;

                    // Normalize the key, matching the logic here:
                    // https://github.dev/dotnet/runtime/blob/main/src/libraries/Microsoft.Extensions.Configuration.EnvironmentVariables/src/EnvironmentVariablesConfigurationProvider.cs
#if NETSTANDARD2_0
                    variableName = variableName.Replace("__", ":");
#else
                    variableName = variableName.Replace("__", ":", StringComparison.OrdinalIgnoreCase);
#endif

                    // For defined prefixes, add the variable with the prefix removed, matching the logic
                    // in EnvironmentVariablesConfigurationProvider.cs. Also add the variable with the
                    // prefix intact, which matches the normal HostApplicationBuilder behavior, where
                    // there's an EnvironmentVariablesConfigurationProvider added with and another one
                    // without the prefix set.
                    foreach (var prefix in prefixesToRemove)
                    {
                        if (variableName.StartsWith(prefix, StringComparison.OrdinalIgnoreCase))
                        {
                            settings.Add(new KeyValuePair<string, string?>(variableName, value));
                            variableName = variableName[prefix.Length..];
                            break;
                        }
                    }

                    if (!string.IsNullOrEmpty(devTunnelId))
                    {
                        value = ReplaceLocalhost(value, devTunnelId);
                    }

                    settings.Add(new(variableName, value));
                }
            }

            builder.Configuration.AddInMemoryCollection(settings);
            return builder;
        }

        static string ReplaceLocalhost(string uri, string devTunnelId)
        {
            // source format is `http[s]://localhost:[port]`
            // tunnel format is `http[s]://exciting-tunnel-[port].devtunnels.ms`

            var tunnel = $"://{devTunnelId}-$1.devtunnels.ms$2";

#if NET7_0_OR_GREATER
            var replacement = LocalhostRegex().Replace(uri, tunnel);
#else
            var replacement = Regex.Replace(uri, LocalhostPattern, tunnel, RegexOptions.Compiled);
#endif

            return replacement;
        }

        const string LocalhostPattern = @"://localhost\:(\d+)(.*)";

#if NET7_0_OR_GREATER
        [GeneratedRegex(LocalhostPattern, RegexOptions.IgnoreCase)]
        private static partial Regex LocalhostRegex();
#endif
    }
}
