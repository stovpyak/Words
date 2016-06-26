using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Words.Model;

namespace Word.WpfAppl.ViewModel
{
    public class WordPairViewModel
    {
        private readonly WordsPair _wordPair;

        public WordPairViewModel(WordsPair wordPair)
        {
            _wordPair = wordPair;
        }

        public string Caption
        {
            get { return $"{_wordPair.First} {_wordPair.Second}"; }
        }
    }
}
