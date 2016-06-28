using System;
using System.Linq;
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
            Console.WriteLine($"Всего слов: {result.AllResults.Count}");

            Console.WriteLine($"Без ошибок: {result.ByBadCount(0, 0).Count()}");
            Console.WriteLine($"С одной ошибкой: {result.ByBadCount(1, 1).Count()}");
            foreach (var word in result.ByBadCount(1, 1))
                Console.WriteLine(word.First);

            Console.WriteLine($"С двумя ошибками: {result.ByBadCount(2, 2).Count()}");
            foreach (var word in result.ByBadCount(2, 2))
                Console.WriteLine(word.First);

            Console.WriteLine($"С тремя ошибками: {result.ByBadCount(3, 3).Count()}");
            foreach (var word in result.ByBadCount(3, 3))
                Console.WriteLine(word.First);

            Console.WriteLine($"Более трех ошибок: {result.ByBadCount(4, null).Count()}");
            foreach (var word in result.ByBadCount(4, null))
                Console.WriteLine(word.First);

            Console.ReadLine();
        }
    }
}
