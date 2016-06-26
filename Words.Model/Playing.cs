using Words.Model.StrategyContracts;

namespace Words.Model
{
    public class Playing
    {
        private readonly IPlayStrategy _playStrategy;
        private WordsPair _currentWordsPair;

        public Playing(IPlayStrategy playStrategy)
        {
            _playStrategy = playStrategy;
        }

        public void Play(IWordDict words)
        {
            IsExit = false;
            while (!IsExit)
            {
                _currentWordsPair = words.GetPair();

                bool isExit;
                _playStrategy.PlayOnePair(_currentWordsPair, new IsExitEnums(), out isExit);
                IsExit = isExit;
            }
        }

        public WordsPair CurrentWordsPair => _currentWordsPair;

        public bool IsExit { get; private set; }
    }
}
