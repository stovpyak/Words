using System.Collections.Generic;

namespace Model
{
    public interface IWordSource
    {
        WordsPair GetPair();

        IEnumerable<WordsPair> AllWords { get; }
    }
}
