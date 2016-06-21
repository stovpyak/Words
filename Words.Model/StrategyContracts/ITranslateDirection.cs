namespace Words.Model.StrategyContracts
{
    public interface ITranslateDirection
    {
        string Name { get; }
    
        Word GetQuestion(WordsPair pair);
        Word GetTranslate(WordsPair pair);

    }
}
