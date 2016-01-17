using System;
using System.Collections.Generic;
using System.Linq;

namespace TextMatcher.Core
{
    public class TextMatchingEngine : ITextMatchingEngine
    {
        public IEnumerable<int> GetIndexes(string text, string query)
        {
            Guard.ThrowExceptionIfNullOrEmpty(text, "text" /* can use nameof() if we are on C# 6*/);
            Guard.ThrowExceptionIfNullOrEmpty(query, "query");

            var result = Enumerable.Range(0, text.Length - query.Length)
                    .Where(i => query.Equals(new string(text.Skip(i).Take(query.Length).ToArray()),
                        StringComparison.OrdinalIgnoreCase)); //Note: The original Substring function uses FastAllocateString unsafe Api.

            return IncreaseOne(result); 
        }

        private static IEnumerable<int> IncreaseOne(IEnumerable<int> result)
        {
            return from index in result
                   select index + 1;
        }
    }
}