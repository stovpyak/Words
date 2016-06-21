using System.Collections.Generic;

namespace Words.Model
{
    public interface IWorldSource
    {
        IEnumerable<WordsPair> GetWords();
    }
}
