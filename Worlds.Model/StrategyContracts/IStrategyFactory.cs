using System.Collections.Generic;

namespace Model.StrategyContracts
{
    public interface IStrategyFactory
    {
        List<IPlayStrategy> BuildAll();
    }
}
