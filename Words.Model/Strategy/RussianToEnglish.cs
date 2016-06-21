using Words.Model.StrategyContracts;

namespace Words.Model.Strategy
{
    public class RussianToEnglish: ITranslateDirection
    {
        public string Name => "Русский->English";

        public Word GetQuestion(WordsPair pair)
        {
            return pair.Second;
        }

        public Word GetTranslate(WordsPair pair)
        {
            return pair.First;
        }
    }
}
