using Model.StrategyContracts;

namespace Model.Strategy
{
    public class TeachOnlyShowStrategy: IPlayStrategy
    {
        private readonly ISpeaker _speaker;
        private readonly IListener _listener;
    
        public TeachOnlyShowStrategy(ISpeaker speaker, IListener listener)
        {
            _speaker = speaker;
            _listener = listener;
        }

        public string Name => "Обучение (только смотрим)";

        public void PlayOnePair(WordsPair pair, ICheckIsExit checkIsExit, out bool isExit)
        {
            isExit = false;

            _speaker.Speak($"{pair.First} = {pair.Second}");
            var input = _listener.Input();
            if (checkIsExit.IsExit(input))
            {
                isExit = true;
            }
        }
    }
}
