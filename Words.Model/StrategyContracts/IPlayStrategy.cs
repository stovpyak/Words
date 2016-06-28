namespace Words.Model.StrategyContracts
{
    public interface IPlayStrategy
    {
        string Name { get; }
    
        bool PlayOnePair(WordsPair pair, ICheckIsExit checkIsExit, out bool isExit);
    }
}
