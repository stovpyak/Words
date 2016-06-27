using Words.Model.StrategyContracts;

namespace Words.Model.Strategy
{
    public class TeachWriteStrategy: IPlayStrategy
    {
        private readonly ISpeaker _speaker;
        private readonly IListener _listener;

        public TeachWriteStrategy(ISpeaker speaker, IListener listener)
        {
            _speaker = speaker;
            _listener = listener;
        }

        public string Name => "Обучение (смотрим и пишем)";

        public bool PlayOnePair(WordsPair pair, ICheckIsExit checkIsExit, out bool isExit)
        {
            var result = true;
            isExit = false;

            _speaker.Speak($"{pair.Second} = {pair.First}");
            _speaker.Speak("Введите слово:");
            var first = _listener.Input();
            if (checkIsExit.IsExit(first))
            {
                isExit = true;
                return result;
            }

            if (first == pair.First.Caption)
            {
                _speaker.Speak("Ok!");
                result = true;
            }
            else
            {
                _speaker.Speak($"No. Правильно будет \"{pair.First}\"");
                result = false;
            }
            _speaker.Speak("");
            return result;

            //_speaker.Speak("Введите второе слово:");
            //var second = _listener.Input();
            //if (checkIsExit.IsExit(second))
            //{
            //    isExit = true;
            //    return;
            //}
            //if (second == pair.Second.Caption)
            //    _speaker.Speak("Ok!");
            //else
            //    _speaker.Speak($"No. Правильно {pair.Second}");
        }
    }
}
