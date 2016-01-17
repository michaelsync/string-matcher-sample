namespace TextMatcher.Core.Tests
{
    public class RegularExpressionTextMatchingEngineTests : TextMatchingEngineTestsBase
    {
        protected override ITextMatchingEngine CreateEngine()
        {
            return new RegularExpressionTextMatchingEngine();
        }
    }
}