using System.Collections.Generic;
using Model.StrategyContracts;

namespace Model.Strategy
{
    public class StrategyFactory: IStrategyFactory
    {
        private readonly ISpeaker _speaker;
        private readonly IListener _listener;

        public StrategyFactory(ISpeaker speaker, IListener listener)
        {
            _speaker = speaker;
            _listener = listener;
        }

        public List<IPlayStrategy> BuildAll()
        {
            var result = new List<IPlayStrategy>();

            result.Add(new TeachOnlyShowStrategy(_speaker, _listener));
            result.Add(new TeachWriteStrategy(_speaker, _listener));

            var testEnglishToRussian = new TestStrategy(3, new EnglishToRussian(), _speaker, _listener);
            result.Add(testEnglishToRussian);

            var testRussianToEnglish = new TestStrategy(3, new RussianToEnglish(), _speaker, _listener);
            result.Add(testRussianToEnglish);

            return result;
        }
    }
}
