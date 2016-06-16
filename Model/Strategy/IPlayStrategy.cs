namespace Model.Strategy
{
    public interface IPlayStrategy
    {
        void PlayOnePair(WordsPair pair, out bool isExit);
    }
}
