using System;

namespace TextMatcher.Core
{
    public static class Guard
    {
        public static void ThrowExceptionIfNullOrEmpty(string value, string parameterName)
        {
            if (string.IsNullOrEmpty(value) || value.Trim().Length == 0)
            {
                throw new ArgumentNullException(parameterName, "Text parameter can't be null");
            }
        } 
    }
}