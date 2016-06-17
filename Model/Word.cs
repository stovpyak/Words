namespace Model
{
    public class Word
    {
        public Word(string caption): this(caption, null)
        {
        }

        public Word(string caption, string transcription)
        {
            Caption = caption;
            Transcription = transcription;
        }

        public string Caption { get; private set; }
        public string Transcription { get; private set; }

        public override string ToString()
        {
            var result = Caption;
            if (Transcription != null)
                result = result + $" / {Transcription} /";
            return result;
        }
    }
}
