namespace ifcodes.ifutilities.ifhosting
{
    internal sealed class Constants
    {
        public static class EnvironmentVariables
        {
            public const string ASPNETCORE_ENVIRONMENT = "ASPNETCORE_ENVIRONMENT"; 
        }

        public static class ConfigurationFile
        {
            public static readonly string CONFIGURATION_FILE_NAME = "appsettings";
            public static readonly string EXTENSION = "json";
            public static readonly string PERIOD = ".";
        }

        public static class Messaging
        {
            public const string ASPNETCORE_ENVIRONMENT_VARIABLE_NOT_SET = "ASPNETCORE_ENVIRONMENT environment variable not set, unable to configure application host.";
            public const string UNRECOVERABLE_ERROR_OCCURRED_GETTING_ASPNETCORE_ENVIRONMENT_VARIABLE = "Unrecoverable error occurred while getting ASPNETCORE_ENVIRONMENT environment variable, unable to configure application host.";
            public const string ASSEMBLY_DOES_NOT_HAVE_ASSEMBLY_CONFIGURATION_ATTRIBUTE = "Assembly not compiled with AssemblyConfigurationAttribute, either recompile assembly from source or redownload nuget package.";
            public const string UNRECOVERABLE_ERROR_OCCURRED_GETTING_ASSEMBLY_CONFIGURATION_ATTRIBUTE = "Unrecoverable error occurred while getting AssemblyConfigurationAttribute.";
        }
    }
}