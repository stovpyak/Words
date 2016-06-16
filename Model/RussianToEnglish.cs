namespace Model
{
    public class RussianToEnglish: ITranslateDirection
    {
        public string GetWord(WordsPair pair)
        {
            return pair.Second;
        }

        public string GetTranslate(WordsPair pair)
        {
            return pair.First;
        }
    }
}
