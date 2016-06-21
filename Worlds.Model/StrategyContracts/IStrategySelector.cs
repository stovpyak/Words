using System.Collections.Generic;

namespace Model.StrategyContracts
{
    public interface IStrategySelector
    {
        IPlayStrategy Select(List<IPlayStrategy> strategies);
    }
}
