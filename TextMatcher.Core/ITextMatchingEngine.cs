using System.Collections.Generic;

namespace TextMatcher.Core
{
    public interface ITextMatchingEngine
    {
        IEnumerable<int> GetIndexes(string text, string query);
    }
}