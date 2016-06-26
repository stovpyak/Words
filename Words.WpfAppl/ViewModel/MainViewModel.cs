using System.Collections.Generic;
using System.Data;
using Words.Model;
using Words.Model.IO;
using Words.Model.Strategy;
using Words.Model.StrategyContracts;

namespace Word.WpfAppl.ViewModel
{
    public class MainViewModel
    {
        private Appl _appl;
        private ListenerViewModel _listener = new ListenerViewModel();

        private List<WordPairViewModel> _wordPairs = new List<WordPairViewModel>();

        public MainViewModel()
        {
            var speaker = new SpeakerDummy();
            //var listener = new ListenerDummy();

            IStrategyFactory strategyFactory = new StrategyFactory(speaker, _listener);
            var strategySelector = new StrategySelector();
            var worldSource = new XmlWorldSource();

            var appl = new Appl(strategyFactory, strategySelector, worldSource);

            _appl = appl;
            //_appl.Run();


            Update();
        }

        private void Update()
        {
            _wordPairs.Clear();
            foreach (var wordPair in _appl.WorldSource.GetWords())
            {
                _wordPairs.Add(new WordPairViewModel(wordPair));
            }
        }

        public List<WordPairViewModel> WordPairs
        {
            get { return _wordPairs; }
        }

        private WordsPair _currentWordsPair;

        public string First
        {
            get { return _currentWordsPair.First.ToString(); }
        }
    }
}
