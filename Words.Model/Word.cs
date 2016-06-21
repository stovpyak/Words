namespace Words.Model
{
    public class Word
    {
        public Word(string caption): this(caption, null)
        {
        }

        public Word(string caption, string transcription): this(caption, transcription, null)
        {
        }

        public Word(string caption, string transcription, string comments)
        {
            Caption = caption;
            Transcription = transcription;
            Comments = comments;
        }
        public string Caption { get; }
        public string Transcription { get; }
        public string Comments { get; }

        public override string ToString()
        {
            var result = Caption;
            if (Transcription != null)
                result = result + $" [{Transcription}]";
            if (Comments != null)
                result = result + $" ({Comments})";

            return result;
        }
    }
}
