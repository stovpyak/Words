using System.Collections.Generic;

namespace Words.Model.StrategyContracts
{
    public interface IStrategySelector
    {
        IPlayStrategy Select(List<IPlayStrategy> strategies);
    }
}
