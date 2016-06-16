namespace Model
{
    public class WordsPair
    {
        public WordsPair(string first, string second)
        {
            First = first;
            Second = second;
        }

        public string First { get; private set; }
        public string Second { get; private set; }

    }
}
