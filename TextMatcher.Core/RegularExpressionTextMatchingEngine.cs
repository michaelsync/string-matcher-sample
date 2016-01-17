using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace TextMatcher.Core
{
    public class RegularExpressionTextMatchingEngine : TextMatchingEngineBase, ITextMatchingEngine
    {
        public IEnumerable<int> GetIndexes(string text, string query)
        {
            ThrowExceptionIfNullOrEmpty(text, query);

            query = Regex.Escape(query);
            var result = from Match match in
                             Regex.Matches(text, query, RegexOptions.IgnoreCase)
                         select match.Index;

            return IncreaseOne(result);
        }
    }
}