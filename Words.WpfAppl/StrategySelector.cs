using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Words.Model.StrategyContracts;

namespace Word.WpfAppl
{
    public class StrategySelector: IStrategySelector
    {
        public IPlayStrategy Select(List<IPlayStrategy> strategies)
        {
            return null;
        }
    }
}
