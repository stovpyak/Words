namespace Model
{
    public class WordsPair
    {
        public WordsPair(Word first, Word second)
        {
            First = first;
            Second = second;
        }

        public Word First { get; private set; }
        public Word Second { get; private set; }
    }
}
