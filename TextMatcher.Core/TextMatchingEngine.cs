using System;
using System.Linq;

namespace TextMatcher.Core
{
    public class TextMatchingEngine : TextMatchingEngineBase, ITextMatchingEngine
    {
        public System.Collections.Generic.IEnumerable<int> GetIndexes(string text, string query)
        {
            ThrowExceptionIfNullOrEmpty(text, query);

            var result = Enumerable.Range(0, text.Length - query.Length)
                    .Where(i => query.Equals(new string(text.Skip(i).Take(query.Length).ToArray()), 
                        StringComparison.OrdinalIgnoreCase));

            return IncreaseOne(result); 
        }
    }
}