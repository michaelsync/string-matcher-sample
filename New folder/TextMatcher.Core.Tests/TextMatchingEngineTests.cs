using System.Linq;
using Xunit;

namespace TextMatcher.Core.Tests {
    public class TextMatchingEngineTests {
        public static string Text = "Polly put the kettle on, polly put the kettle on, polly put the kettle on we'll all have tea";

        [Fact(DisplayName = "The ArgumentNull exception is thrown when any of the arguments is null or empty.")]
        private void Exception_is_thrown_when_argument_are_null() {
            ITextMatchingEngine engine = new TextMatchingEngine();
            var result = engine.Analyze(Text, "Polly");

            Assert.Equal(3, result.Count());
        }
    }
}
