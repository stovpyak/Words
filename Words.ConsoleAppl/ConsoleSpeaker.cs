using System;
using Words.Model;

namespace Words.ConsoleAppl
{
    public class ConsoleSpeaker: ISpeaker
    {
        public void Speak(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}
