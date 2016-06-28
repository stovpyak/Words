using System;
using Words.Model;
using Words.Model.IO;
using Words.Model.Strategy;
using Words.Model.StrategyContracts;

namespace Words.ConsoleAppl
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
            var result = appl.Run();

            Console.WriteLine("Результат:");
            Console.WriteLine($"Всего слов {result.AllCount()}");
            Console.WriteLine($"Правильно {result.Good.Count}");
            Console.WriteLine($"Не правильно {result.Bad.Count}");
            Console.WriteLine("");
            Console.ReadLine();

            if (result.Bad.Count > 0)
            {
                Console.WriteLine("Неправильные ответы:");
                foreach (var bad in result.Bad)
                {
                    Console.WriteLine(bad.First);
                }
                Console.ReadLine();
            }
        }
    }
}
