namespace TextMatcher.Core.Tests
{
    public class DefaultDotNetTextMatchingEngineTests : TextMatchingEngineTestsBase
    {
        protected override ITextMatchingEngine CreateEngine()
        {
            return new DefaultDotNetTextMatchingEngine();
        }
    }
}