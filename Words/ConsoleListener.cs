using System;
using Model;

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
