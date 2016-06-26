using Words.Model.StrategyContracts;

namespace Words.Model
{
    public class Appl
    {
        private readonly IStrategyFactory _strategyFactory;
        private readonly IStrategySelector _strategySelector;
        private readonly IWorldSource _worldSource;
        private Playing _playing;

        public Appl(IStrategyFactory strategyFactory, IStrategySelector strategySelector,
            IWorldSource worldSource)
        {
            _strategyFactory = strategyFactory;
            _strategySelector = strategySelector;
            _worldSource = worldSource;
        }

        public void Run()
        {
            var strategies = _strategyFactory.BuildAll();
            var strategy = _strategySelector.Select(strategies);
            _playing = new Playing(strategy);

            var wordsDict = new WordsDict();
            wordsDict.AddWords(_worldSource.GetWords());

            _playing.Play(wordsDict);
        }

        public IWorldSource WorldSource => _worldSource;

        private Playing Playing => _playing;
    }
}
