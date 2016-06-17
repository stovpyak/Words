namespace Model
{
    public interface ITranslateDirection
    {
        Word GetQuestion(WordsPair pair);
        Word GetTranslate(WordsPair pair);
    }
}
