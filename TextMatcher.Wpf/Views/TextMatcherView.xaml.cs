using System.Windows.Controls;
using TextMatcher.Wpf.ViewModels;

namespace TextMatcher.Wpf.Views
{
    /// <summary>
    /// Interaction logic for TextMatcherView.xaml
    /// </summary>
    public partial class TextMatcherView : UserControl
    {
        public TextMatcherView(TextMatcherViewModel viewModel)
        {
            InitializeComponent();
            this.DataContext = viewModel;
        }
    }
}
