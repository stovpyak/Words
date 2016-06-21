using System.Collections.Generic;
using Words.Model.StrategyContracts;

namespace Word.WpfAppl
{
    public class StrategySelector: IStrategySelector
    {
        public IPlayStrategy Select(List<IPlayStrategy> strategies)
        {
            return strategies[0];
        }
    }
}
