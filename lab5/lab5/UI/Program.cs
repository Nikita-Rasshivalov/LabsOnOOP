using System;
using System.Collections.Generic;


namespace UI
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> mobilNumbers = new List<string>();

            int exit = 3;
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

                    default:
                        Console.WriteLine("Ошибка ввода");
                        break;
                }
            }
        }
        public static int GetChoice()
        {
            int choice;
            Console.WriteLine("Выберите:\n1.Добавить номера\n" +
                "2.Вывод отсортированных номеров\n3.Выход");
            string input = Console.ReadLine();
            int.TryParse(input, out choice);
            return choice;
        }
    }
}

