using TextMatcher.Core;

namespace TextMatcher.Wpf.ViewModels
{
    public class TextMatcherViewModel
    {
        public TextMatcherViewModel()
        {
            
        }

        public string Text { get; set; }
        public string Query { get; set; }

        public string GetIndexesCommand { get; set; }

        public string Result { get; set; }
    }
}