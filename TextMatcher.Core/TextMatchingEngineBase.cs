using System.Collections.Generic;
using System.Linq;

namespace TextMatcher.Core
{
    public abstract class TextMatchingEngineBase
    {
        protected static void ThrowExceptionIfNullOrEmpty(string text, string query)
        {
            Guard.ThrowExceptionIfNullOrEmpty(text, "text" /* can use nameof() if we are on C# 6*/);
            Guard.ThrowExceptionIfNullOrEmpty(query, "query");
        }
        protected static IEnumerable<int> IncreaseOne(IEnumerable<int> result)
        {
            return from index in result
                   select index + 1;
        }
    }
}