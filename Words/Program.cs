using System;
using System.Text;
using Model;
using Model.IO;
using Model.Strategy;

namespace Words
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
         
            Console.WriteLine("Английские слова:");

            var speaker = new ConsoleSpeaker();
            var listener = new ConsoleListener();

            
            // todo: сам выбор оставить во View, а последствия выбора в модель
            Console.WriteLine("Выберите режим:");
            Console.WriteLine("1) Обучение: English + Русский");
            Console.WriteLine("2) Тест: English -> Русский");
            Console.WriteLine("3) Тест: Русский -> English");
            var mode = Console.ReadLine();


            IPlayStrategy playStrategy;
            if (mode == "1")
            {
                playStrategy = new TeachStrategy(speaker, listener);
            }
            else if (mode == "2")
            {
                var translateDirection = new EnglishToRussian();
                playStrategy = new TestStrategy(3, translateDirection, speaker, listener);
            }
            else
            {
                var translateDirection = new RussianToEnglish();
                playStrategy = new TestStrategy(3, translateDirection, speaker, listener);
            }

            var playing = new Playing(playStrategy);

            var xml = new XmlDictionary();
            var wordsSource = new WordsDict();
            // todo: какие словари использовать пока зашито в код
            wordsSource.AddWords(xml.ReadFromFile("lesson-1.xml"));
            wordsSource.AddWords(xml.ReadFromFile("lesson-2.xml"));
            wordsSource.AddWords(xml.ReadFromFile("lesson-3. character.xml"));
            wordsSource.AddWords(xml.ReadFromFile("lesson-3. jobs.xml"));

            Console.WriteLine("Для выхода введите Q");

            playing.Play(wordsSource);
        }
    }
}
