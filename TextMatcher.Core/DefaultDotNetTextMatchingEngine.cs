using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using EnsureThat;

namespace TextMatcher.Core
{
    public class DefaultDotNetTextMatchingEngine :TextMatchingEngineBase, ITextMatchingEngine
    {
        public IEnumerable<int> GetIndexes(string text, string query)
        {
            ThrowExceptionIfNullOrEmpty(text, query);

            var result = Enumerable.Range(0, text.Length - query.Length)
                    .Where(i => query.Equals(text.Substring(i, query.Length), StringComparison.OrdinalIgnoreCase));

            return IncreaseOne(result); 
        }

        
    }
}