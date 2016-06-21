using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Words.Model;

namespace Words
{
    public class ConsoleSpeaker: ISpeaker
    {
        public void Speak(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}
