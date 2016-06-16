using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class EnglishToRussian: ITranslateDirection
    {
        public string GetWord(WordsPair pair)
        {
            return pair.First;
        }

        public string GetTranslate(WordsPair pair)
        {
            return pair.Second;
        }
    }
}
