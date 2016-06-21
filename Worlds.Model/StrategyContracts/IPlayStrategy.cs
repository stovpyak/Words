namespace Model.StrategyContracts
{
    public interface IPlayStrategy
    {
        string Name { get; }
    
        void PlayOnePair(WordsPair pair, ICheckIsExit checkIsExit, out bool isExit);
    }
}
