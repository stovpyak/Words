using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Words.Model
{
    public class PlayResult
    {
        public PlayResult(HashSet<WordsPair> good, HashSet<WordsPair> bad)
        {
            Good = good;
            Bad = bad;
        }

        public HashSet<WordsPair> Good { get; private set; }

        public HashSet<WordsPair> Bad { get; private set; }

        public int AllCount()
        {
            return Good.Count + Bad.Count;
        }

        public double GoodPercent()
        {
            return Good.Count / AllCount();
        }
    }
}
