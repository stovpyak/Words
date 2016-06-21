using System;
using Words.Model;

namespace Words.ConsoleAppl
{
    public class ConsoleListener: IListener
    {
        public string Input()
        {
            return Console.ReadLine();
        }
    }
}
