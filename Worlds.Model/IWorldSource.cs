using System.Collections.Generic;

namespace Model
{
    public interface IWorldSource
    {
        IEnumerable<WordsPair> GetWords();
    }
}
