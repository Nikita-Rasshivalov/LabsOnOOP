using System;
using System.Collections.Generic;


namespace UI
{
 /// <summary>
 /// User interface
 /// </summary>
    class Program
    {
        /// <summary>
        /// Point of entery
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            List<string> mobilNumbers = new List<string>();

            int exit = 4;
            int choice = 0;
            while (choice != exit)
            {
                choice = GetChoice();
                Console.Clear();
                switch (choice)
                {
                    case 1:
                        WorkWithNumbers.EnterNumbers(mobilNumbers);
                        break;
                    case 2:
                        WorkWithNumbers.ShowNumbers(mobilNumbers);
                        break;
                    case 3:
                        Console.WriteLine("Введите строку");
                        string initialString = Console.ReadLine();
                        WorkWithNumbers.ParseString(initialString);
                        break;

                    default:
                        Console.WriteLine("Ошибка ввода");
                        break;
                }
            }
        }

        /// <summary>
        /// Get choice
        /// </summary>
        /// <returns>Your choice</returns>
        public static int GetChoice()
        {
            int choice;
            Console.WriteLine("Выберите:\n1.Добавить номера\n" +
                "2.Вывод отсортированных номеров\n3.Вывод символов\n4.Выход");
            string input = Console.ReadLine();
            int.TryParse(input, out choice);
            return choice;
        }
    }
}

