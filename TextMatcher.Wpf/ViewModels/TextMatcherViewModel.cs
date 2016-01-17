using System.ComponentModel;
using System.Globalization;
using System.Windows.Input;

namespace TextMatcher.Wpf.ViewModels
{
    public class TextMatcherViewModel : INotifyPropertyChanged
    {
        public TextMatcherViewModel()
        {

        }

        private string _text = string.Empty;
        public string Text
        {
            get { return _text; }
            set
            {
                _text = value;
                RaisePropertyChangedEvent("Text");
                RaisePropertyChangedEvent("IsButtonEnabled");
            }
        }
        
        public bool IsButtonEnabled
        {
            get { return (_text.Trim().Length > 0) && (_query.Trim().Length > 0); }
        }

        private string _query = string.Empty;
        public string Query
        {
            get { return _query; }
            set
            {
                _query = value;
                RaisePropertyChangedEvent("Query");
                RaisePropertyChangedEvent("IsButtonEnabled");
            }
        }

        private string _result;
        public string Result
        {
            get
            {
                return _result;

            }
            set
            {
                _result = string.Format(CultureInfo.InvariantCulture, "Result : {0}", value);
                RaisePropertyChangedEvent("Result");
            }
        }

        public ICommand GetIndexesCommand { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void RaisePropertyChangedEvent(string propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}