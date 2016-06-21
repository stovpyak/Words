using System;
using System.Collections.Generic;

namespace Model
{
    public class WordsDict: IWordDict
    {
        private readonly List<WordsPair> _pairs = new List<WordsPair>();
        private readonly Random rnd = new Random();

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
            // todo: пока стратегия выдачи одна - случайное слово
            var index = rnd.Next(0, _pairs.Count);
            return _pairs[index];
        }

        private void SampleInitDict()
        {
            _pairs.Add(new WordsPair(new Word("bold"), new Word("лысый")));
            _pairs.Add(new WordsPair(new Word("ugly"), new Word("ужасный")));
            _pairs.Add(new WordsPair(new Word("slim"), new Word("стройный")));
            _pairs.Add(new WordsPair(new Word("tall"), new Word("высокий")));
        }

        public IEnumerable<WordsPair> AllWords => _pairs;
    }
}
