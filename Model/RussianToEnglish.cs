namespace Model
{
    public class RussianToEnglish: ITranslateDirection
    {
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
