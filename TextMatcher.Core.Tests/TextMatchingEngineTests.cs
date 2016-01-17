namespace TextMatcher.Core.Tests
{
    public class TextMatchingEngineTests : TextMatchingEngineTestsBase
    {
        protected override ITextMatchingEngine CreateEngine()
        {
            return new TextMatchingEngine();
        }
    }
}