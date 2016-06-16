namespace Model.Strategy
{
    public class TestStrategy: IPlayStrategy
    {
        private readonly int _maxCountForOneWord;
        private readonly ITranslateDirection _translateDirection;
        private readonly ISpeaker _speaker;
        private readonly IListener _listener;

        public TestStrategy(int maxCountForOneWord, ITranslateDirection translateDirection, 
            ISpeaker speaker, IListener listener)
        {
            _maxCountForOneWord = maxCountForOneWord;
            _translateDirection = translateDirection;
            _speaker = speaker;
            _listener = listener;
        }

        public void PlayOnePair(WordsPair pair, out bool isExit)
        {
            isExit = false;

            int currentCount = 0;
            while (currentCount < _maxCountForOneWord)
            {
                _speaker.Speak($"{_translateDirection.GetWord(pair)}: ");
                var input = _listener.Input();
                if ((input == "Q") || (input == "q") || (input == "й") || (input == "Й"))
                {
                    isExit = true;
                    break;
                }
                if (_translateDirection.GetTranslate(pair) == input)
                {
                    _speaker.Speak("Oк!");
                    break;
                }
                _speaker.Speak("No");
                currentCount = currentCount + 1;
            }
            if (currentCount >= _maxCountForOneWord)
                _speaker.Speak($"Правильный ответ: {_translateDirection.GetTranslate(pair)}");
        }
    }
}
