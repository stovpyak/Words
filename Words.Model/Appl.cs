using Words.Model.StrategyContracts;

namespace Words.Model
{
    public class Appl
    {
        private readonly IStrategyFactory _strategyFactory;
        private readonly IStrategySelector _strategySelector;
        private readonly IWorldSource _worldSource;

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
            var playing = new Playing(strategy);

            var wordsDict = new WordsDict();
            wordsDict.AddWords(_worldSource.GetWords());

            playing.Play(wordsDict);
        }
    }
}
