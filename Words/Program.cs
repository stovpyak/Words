using System;
using Words.Model;
using Words.Model.IO;
using Words.Model.Strategy;
using Words.Model.StrategyContracts;

namespace Words
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("Английские слова:");
            Console.WriteLine("Для выхода введите Q");
            
            var speaker = new ConsoleSpeaker();
            var listener = new ConsoleListener();

            IStrategyFactory strategyFactory = new StrategyFactory(speaker, listener);
            var strategySelector = new StrategySelector();
            var worldSource = new XmlWorldSource();

            var appl = new Appl(strategyFactory, strategySelector, worldSource);
            appl.Run();
        }
    }
}
