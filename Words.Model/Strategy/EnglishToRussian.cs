using Words.Model.StrategyContracts;

namespace Words.Model.Strategy
{
    public class EnglishToRussian: ITranslateDirection
    {
        public string Name => "English -> Русский";

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
