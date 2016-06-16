namespace Model
{
    public interface ITranslateDirection
    {
        string GetWord(WordsPair pair);
        string GetTranslate(WordsPair pair);
    }
}
