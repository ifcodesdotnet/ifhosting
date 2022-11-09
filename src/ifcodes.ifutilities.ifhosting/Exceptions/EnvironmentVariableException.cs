#region Imports
using System;
#endregion

namespace ifcodes.ifutilities.ifhosting.Exceptions
{
    public class EnvironmentVariableException : Exception
    {
        public EnvironmentVariableException()
        {
        }

        public EnvironmentVariableException(string message)
            : base(message)
        {
        }

        public EnvironmentVariableException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}