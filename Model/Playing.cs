using Model.Strategy;

namespace Model
{
    public class Playing
    {
        private readonly IPlayStrategy _playStrategy;
        
        public Playing(IPlayStrategy playStrategy)
        {
            _playStrategy = playStrategy;
        }

        public void Play(IWordSource words)
        {
            IsExit = false;
            while (!IsExit)
            {
                var pair = words.GetPair();

                bool isExit;
                _playStrategy.PlayOnePair(pair, out isExit);
                IsExit = isExit;
            }
        }

        public bool IsExit { get; private set; }
    }
}
