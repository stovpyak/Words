using Words.Model;

namespace Word.WpfAppl.ViewModel
{
    public class ListenerViewModel: IListener
    {
        private string _inputValue;

        public string Input()
        {
            while (InputValue == null)
            {
            }
            return InputValue;
        }

        public string InputValue
        {
            get { return _inputValue; }
            set { _inputValue = value; }
        }
    }
}
