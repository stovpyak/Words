using System;
using System.Collections.Generic;

namespace Model
{
    public class WordsDict: IWordSource
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
            // пока стратегия выдачи одна - случайное слово
            var index = rnd.Next(0, _pairs.Count);
            return _pairs[index];
        }

        private void SampleInitDict()
        {
            _pairs.Add(new WordsPair("bold", "лысый"));
            _pairs.Add(new WordsPair("ugly", "ужасный"));
            _pairs.Add(new WordsPair("slim", "стройный"));
            _pairs.Add(new WordsPair("tall", "высокий"));
        }

        public IEnumerable<WordsPair> AllWords => _pairs;
    }
}
