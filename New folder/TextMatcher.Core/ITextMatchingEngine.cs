using System.Collections.Generic;

namespace TextMatcher.Core {
    public interface ITextMatchingEngine {
        IEnumerable<int> Analyze(string text, string subText);
    }
}
