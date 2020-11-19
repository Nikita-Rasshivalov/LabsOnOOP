using System;
using WorkWithStrings;
using System.Text.RegularExpressions;
using System.Text;

namespace Strings
{
    /// <summary>
    /// User inerface
    /// </summary>
    class UI
    {
        /// <summary>
        /// Point of entry
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int exit = 3;
            int choice = 0;
            while (choice != exit)
            {
                choice = GetChoice();
                Console.Clear();
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Введите исходную  строку");
                        string initialString = Console.ReadLine();

                        string pattern = @"[a-zA-Z]";
                        if (Regex.IsMatch(initialString, pattern))
                        {
                            Console.WriteLine("Строка должна содержать только русские символы! ");
                        }
                        else
                        {
                            string newString = Words.DelRepeatedWord(initialString);
                            Console.WriteLine($"Новая строка:{newString}");
                        }

                        break;
                    case 2:
                        Console.WriteLine("Введите исходную  строку");
                        Console.WriteLine("Пример ввода: vk.com 24.12.2002 16-59.");
                        string dataString = Console.ReadLine();
                        StringBuilder result = Words.GetString(dataString);
                        
                        if (result != null)
                        {
                            Console.WriteLine(result);
                                                   
                        }
                        else
                        {
                            Console.WriteLine("Данные введены некорректно ");
                        }
                        break;

                    default:
                        Console.WriteLine("Ошибка ввода");
                        break;
                }
            }
        }

        /// <summary>
        /// Method of getting choice
        /// </summary>
        /// <returns>Your choice</returns>
        static int GetChoice()
        {
            int choice;
            Console.WriteLine("Выберите:\n1.Получить в новой строке отредактированный текст в котором удалены подряд идущие вхождения слов в предложении\n" +
                "2.Получить строку из адресов с датой подключения(подключение осущетсвялось  1 раз), .\n3.Выход");
            string input = Console.ReadLine();
            int.TryParse(input, out choice);
            return choice;
        }
    }
}
