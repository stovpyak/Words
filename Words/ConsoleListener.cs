using System;
using Words.Model;

namespace Words
{
    public class ConsoleListener: IListener
    {
        public string Input()
        {
            return Console.ReadLine();
        }
    }
}
