using System.Collections.Generic;

namespace Words.Model
{
    public class PlayResult
    {
        private readonly Dictionary<WordsPair, WordPairResult> _wordToResultDict = new Dictionary<WordsPair, WordPairResult>();

        public void AddCorrect(WordsPair pair)
        {
            var result = GetOrMakeResult(pair);
            result.IncCorrect();
        }

        public void AddBad(WordsPair pair)
        {
            var result = GetOrMakeResult(pair);
            result.IncBad();
        }

        private WordPairResult GetOrMakeResult(WordsPair pair)
        {
            WordPairResult result;
            if (_wordToResultDict.ContainsKey(pair))
            {
                result = _wordToResultDict[pair];
            }
            else
            {
                result = new WordPairResult();
                _wordToResultDict.Add(pair, result);
            }
            return result;
        }

        public Dictionary<WordsPair, WordPairResult> AllResults => _wordToResultDict;

        public IEnumerable<WordsPair> ByBadCount(int badMinCount, int? badMaxCount)
        {
            var result = new List<WordsPair>();

            var keys = _wordToResultDict.Keys;
            foreach (var key in keys)
            {
                var wordResult = _wordToResultDict[key];
                if ((wordResult.Bad >= badMinCount) && 
                        ((badMaxCount == null) || ((badMaxCount != null) && (wordResult.Bad <= badMaxCount))))
                    result.Add(key);
            }
            return result;
        }
    }

    public class WordPairResult
    {
        public void IncCorrect()
        {
            Correct = Correct + 1;
        }

        public void IncBad()
        {
            Bad = Bad + 1;
        }

        public int Correct { get; private set; }
        public int Bad { get; private set; }
    }
}
