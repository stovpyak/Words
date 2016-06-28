using Words.Model.StrategyContracts;

namespace Words.Model.Strategy
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

        public string Name => $"Тест: {_translateDirection.Name}";

        public bool PlayOnePair(WordsPair pair, ICheckIsExit checkIsExit, out bool isExit)
        {
            var result = false;
            isExit = false;

            int currentCount = 0;
            while (currentCount < _maxCountForOneWord)
            {
                _speaker.Speak($"{_translateDirection.GetQuestion(pair)}: ");
                var input = _listener.Input();
                if (checkIsExit.IsExit(input))
                {
                    isExit = true;
                    return true;
                }
                if (_translateDirection.GetTranslate(pair).Caption == input)
                {
                    _speaker.Speak("Oк!");
                    if (currentCount == 0)
                        result = true;
                    break;
                }
                else
                {
                    _speaker.Speak("No!");
                    result = false;
                }
                currentCount = currentCount + 1;
            }

            if (currentCount >= _maxCountForOneWord)
            {
                _speaker.Speak($"Правильный ответ: {_translateDirection.GetTranslate(pair)}");
                _speaker.Speak($"Введите правильный ответ:");
                var input = _listener.Input();
                if (checkIsExit.IsExit(input))
                {
                    isExit = true;
                    return false;
                }
                if (_translateDirection.GetTranslate(pair).Caption == input)
                    _speaker.Speak("Oк!");
                else
                    _speaker.Speak("No!");
            }
            _speaker.Speak("");
            return result;
        }
    }
}
