using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Words.Model;

namespace Word.WpfAppl
{
    public class ListenerDummy: IListener
    {
        public string Input()
        {
            return "It is a dummy";
        }
    }
}
