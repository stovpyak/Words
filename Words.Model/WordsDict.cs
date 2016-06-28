using System;
using System.Collections.Generic;

namespace Words.Model
{
    public class WordsDict: IWordDict
    {
        private readonly List<WordsPair> _pairs = new List<WordsPair>();
        private GiveWordsStrategy _giveWordsStrategy;

        public WordsDict()
        {
            SetGiveWordsStrategy(new GiveWordsStrategyRnd());
            //SetGiveWordsStrategy(new GiveWordsStrategyInOrder());
        }

        public void AddSampleWords()
        {
            SampleInitDict();
        }

        public void AddWords(IEnumerable<WordsPair> pairs)
        {
            _pairs.AddRange(pairs);
        }

        public WordsPair GetPair()
        {
            var index = GetIndex();
            return _pairs[index];
        }

        private int GetIndex()
        {
            return _giveWordsStrategy.GetIndex();
        }

        private void SampleInitDict()
        {
            _pairs.Add(new WordsPair(new Word("bold"), new Word("лысый")));
            _pairs.Add(new WordsPair(new Word("ugly"), new Word("ужасный")));
            _pairs.Add(new WordsPair(new Word("slim"), new Word("стройный")));
            _pairs.Add(new WordsPair(new Word("tall"), new Word("высокий")));
        }

        public void SetGiveWordsStrategy(GiveWordsStrategy strategy)
        {
            _giveWordsStrategy = strategy;
            _giveWordsStrategy.AssignWords(_pairs);
        }

        public IEnumerable<WordsPair> AllWords => _pairs;


        public abstract class GiveWordsStrategy
        {
            public abstract int GetIndex();

            public abstract void AssignWords(List<WordsPair> pairs);
        }

        public class GiveWordsStrategyRnd : GiveWordsStrategy
        {
            private List<WordsPair> _pairs;
            private readonly Random _rnd = new Random();

            public override int GetIndex()
            {
                return _rnd.Next(0, _pairs.Count);
            }

            public override void AssignWords(List<WordsPair> pairs)
            {
                _pairs = pairs;
            }
        }

        public class GiveWordsStrategyInOrder : GiveWordsStrategy
        {
            private List<WordsPair> _pairs;
            private int _currentIndex;

            public override int GetIndex()
            {
                if (_currentIndex >= _pairs.Count)
                    _currentIndex = 0;
                var index = _currentIndex;
                _currentIndex = _currentIndex + 1;

                return index;
            }

            public override void AssignWords(List<WordsPair> pairs)
            {
                _pairs = pairs;
            }
        }
    }
}
