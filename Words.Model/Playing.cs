using System.Collections.Generic;
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

        public PlayResult Play(IWordDict words)
        {
            var results = new PlayResult();

            IsExit = false;
            while (!IsExit)
            {
                _currentWordsPair = words.GetPair();

                bool isExit;
                var pairResult = _playStrategy.PlayOnePair(_currentWordsPair, new IsExitEnums(), out isExit);

                if (pairResult)
                    results.AddCorrect(_currentWordsPair);
                else
                    results.AddBad(_currentWordsPair);

                IsExit = isExit;
            }

            return results;
        }

        public WordsPair CurrentWordsPair => _currentWordsPair;

        public bool IsExit { get; private set; }
    }
}
