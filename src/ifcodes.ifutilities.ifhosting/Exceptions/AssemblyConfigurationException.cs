#region Imports
using System;
#endregion

namespace ifcodes.ifutilities.ifhosting.Exceptions
{
    public class AssemblyConfigurationException : Exception
    {
        public AssemblyConfigurationException()
        {
        }

        public AssemblyConfigurationException(string message)
            : base(message)
        {
        }

        public AssemblyConfigurationException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}