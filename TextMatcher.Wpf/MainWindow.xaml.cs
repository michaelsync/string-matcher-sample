using System.Windows;
using Autofac;
using TextMatcher.Core;
using TextMatcher.Wpf.ViewModels;
using TextMatcher.Wpf.Views;

namespace TextMatcher.Wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            var builder = new ContainerBuilder();
            builder.RegisterType<TextMatchingEngine>().As<ITextMatchingEngine>();
            builder.RegisterInstance(new TextMatcherViewModel());
            builder.RegisterInstance(new TextMatcherView());
            var container = builder.Build();

            ContentControl.Content = container.Resolve<TextMatcherView>();
        }
    }
}
