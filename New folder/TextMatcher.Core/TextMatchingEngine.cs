using System;
using System.Collections.Generic;

namespace TextMatcher.Core {
    public class TextMatchingEngine : ITextMatchingEngine {
        public IEnumerable<int> Analyze(string text, string subText) {
            if (string.IsNullOrEmpty(text?.Trim())) {
                throw new ArgumentNullException(nameof(text), "Text parameter must not be null or empty");
            }
            return null;
        }
    }
}
