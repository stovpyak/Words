using System.Collections.Generic;

namespace Words.Model.StrategyContracts
{
    public interface IStrategyFactory
    {
        List<IPlayStrategy> BuildAll();
    }
}
