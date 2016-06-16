namespace Model.Strategy
{
    public class TeachStrategy: IPlayStrategy
    {
        private readonly ISpeaker _speaker;
        private readonly IListener _listener;
    
        public TeachStrategy(ISpeaker speaker, IListener listener)
        {
            _speaker = speaker;
            _listener = listener;
        }

        public void PlayOnePair(WordsPair pair, out bool isExit)
        {
            isExit = false;

            _speaker.Speak($"{pair.First} = {pair.Second}");
            var input = _listener.Input();
            if ((input == "Q") || (input == "q") || (input == "й") || (input == "Й"))
            {
                isExit = true;
            }
        }
    }
}
