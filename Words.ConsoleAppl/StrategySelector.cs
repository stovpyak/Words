using System;
using System.Collections.Generic;
using Words.Model.StrategyContracts;

namespace Words.ConsoleAppl
{
    public class StrategySelector: IStrategySelector
    {
        public IPlayStrategy Select(List<IPlayStrategy> strategies)
        {
            Console.WriteLine("Выберите режим:");

            for (int i = 0; i < strategies.Count; i++)
            {
                Console.WriteLine($"{i+1}) {strategies[i].Name}");
            }

            while (true)
            {
                var input = Console.ReadLine();
                int index = int.Parse(input) - 1;
                if ((index >= 0) && (index < strategies.Count))
                {
                    return strategies[index];
                }
                else
                    Console.WriteLine($"Вы ввели некорректное число. Попробуйте ещё раз...");
            }
        }
    }
}
