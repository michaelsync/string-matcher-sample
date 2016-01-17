using Moq;
using TextMatcher.Core;
using TextMatcher.Wpf.ViewModels;
using Xunit;

namespace TextMatcher.Wpf.Tests
{
    public class TextMatcherViewModelTests
    {
        [Fact(DisplayName = "IsEnabledButton binding property should be false when there is no input for Text and Subtext.")]
        private void Button_should_be_disabled_when_text_and_query_are_empty()
        {
          var mockTextMatchingEngine = new Mock<ITextMatchingEngine>();

          var viewModel = new TextMatcherViewModel(mockTextMatchingEngine.Object);
          Assert.False(viewModel.IsButtonEnabled);
        } 
    }
}