using System;
using System.Text;

namespace Exercises
{
    public class AdvertisingMessageGenerator
    {
        private static string[] courageousPhrases = new string[] { "Продуктът е отличен.", "Това е страхотен продукт.",
            "Постоянно ползвам този продукт.", "Това е най-добрият продукт от тази категория." };
        private static string[] courageousEvents = new string[] {"Вече се чувствам добре.", "Успях да се променя.", "Той направи чудо.",
            "Не мога да повярвам, но вече се чувствам страхотно.", "Опитайте и вие. Аз съм много доволна."};

        private static string[] authorFirstNames = new string[] { "Диана", "Петя", "Стела", "Елена", "Катя" };
        private static string[] authorLastNames = new string[] { "Иванова", "Петрова", "Кирова" };
        private static string[] cities = new string[] { "София", "Пловдив", "Варна", "Русе", "Бургас" };

        private static Random rnd = new Random();
        public static void Run()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < 10; i++)
            {
                sb.Append(courageousPhrases[rnd.Next(courageousPhrases.Length)]);
                sb.Append(" ");
                sb.Append(courageousEvents[rnd.Next(courageousEvents.Length)]);
                sb.AppendLine();
                sb.Append("-=");
                sb.Append(authorFirstNames[rnd.Next(authorFirstNames.Length)]);
                sb.Append(" ");
                sb.Append(authorLastNames[rnd.Next(authorLastNames.Length)]);
                sb.Append(" ");

                sb.Append(cities[rnd.Next(cities.Length)]);

                Console.WriteLine(sb.ToString());
                sb.Clear();
            }
        }

    }
}
