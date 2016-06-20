using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class EnglishToRussian: ITranslateDirection
    {
        public Word GetQuestion(WordsPair pair)
        {
            return pair.First;
        }

        public Word GetTranslate(WordsPair pair)
        {
            return pair.Second;
        }
    }
}
