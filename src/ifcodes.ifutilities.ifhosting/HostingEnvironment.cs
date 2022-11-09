#region Imports
using System;
using System.Reflection;
using ifcodes.ifutilities.ifhosting.Exceptions;
#endregion

namespace ifcodes.ifutilities.ifhosting
{
    /// <summary>
    /// Contains utility methods for streamlining .NET 6 Web & Console Applicaton Hosting Configuration.
    /// </summary>
    public static class HostingEnvironment
    {
        /// <summary>
        /// Retrieves the value of the ASPNETCORE_ENVIRONMENT environment variable.
        /// </summary>
        /// <returns>The value of the ASPNETCORE_ENVIRONMENT environment variable.</returns>
        /// <exception cref="EnvironmentVariableException"></exception>
        /// <exception cref="Exception"></exception>
        public static string GetEnvironmentFromEnvironmentVariable()
        {
            try
            {
                string environment = Environment.GetEnvironmentVariable(Constants.EnvironmentVariables.ASPNETCORE_ENVIRONMENT);

                if (string.IsNullOrEmpty(environment))
                {
                    throw new EnvironmentVariableException(Constants.Messaging.ASPNETCORE_ENVIRONMENT_VARIABLE_NOT_SET); 
                }

                return environment.ToLower();
            }
            catch (EnvironmentVariableException ex)
            {
                throw new EnvironmentVariableException(ex.Message, ex); 
            }
            catch (Exception ex)
            {
                throw new Exception(Constants.Messaging.UNRECOVERABLE_ERROR_OCCURRED_GETTING_ASPNETCORE_ENVIRONMENT_VARIABLE, ex); 
            }
        }

        /// <summary>
        /// Retrieves the value of the AssemblyConfigurationAttribute from the assembly of the passed in type.
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        /// <exception cref="AssemblyConfigurationException"></exception>
        /// <exception cref="Exception"></exception>
        public static string GetAssemblyBuildConfigurationFromType(Type type)
        {
            try
            {
                AssemblyConfigurationAttribute assembly = type.Assembly.GetCustomAttribute<AssemblyConfigurationAttribute>();

                if (string.IsNullOrEmpty(assembly.Configuration))
                {
                    throw new AssemblyConfigurationException(Constants.Messaging.ASSEMBLY_DOES_NOT_HAVE_ASSEMBLY_CONFIGURATION_ATTRIBUTE); 
                }

                return assembly.Configuration;
            }
            catch (AssemblyConfigurationException ex)
            {
                throw new Exception(ex.Message, ex);
            }
            catch (Exception ex)
            {
                throw new Exception(Constants.Messaging.UNRECOVERABLE_ERROR_OCCURRED_GETTING_ASSEMBLY_CONFIGURATION_ATTRIBUTE, ex);
            }
        }

        /// <summary>
        /// todo add a comment here
        /// </summary>
        public static string GetConfigurationFile()
        {

            return Constants.ConfigurationFile.CONFIGURATION_FILE_NAME + Constants.ConfigurationFile.PERIOD + Constants.ConfigurationFile.EXTENSION; 
        }

        /// <summary>
        /// todo add a comment here
        /// </summary>
        /// <param name="environment"></param>
        public static string GetConfigurationFile(string environment)
        {

            return Constants.ConfigurationFile.CONFIGURATION_FILE_NAME + Constants.ConfigurationFile.PERIOD + environment  + Constants.ConfigurationFile.PERIOD + Constants.ConfigurationFile.EXTENSION;
        }
    }
}