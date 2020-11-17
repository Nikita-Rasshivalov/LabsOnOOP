using System;
using System.Collections.Generic;
using PhoneNumbers;

namespace UI
{
    public static class WorkWithNumbers
    {

        public static void EnterNumbers(List<string> mobileNumbers)
        {
            Console.WriteLine("Сколько добавить номеров?");
            int number;
            string input = Console.ReadLine();
            int.TryParse(input, out number);
            Console.Write("Пример ввода:+37529(33)(44)(25)1111111 или 29(33)(44)(25)1111111 или 1111111  \n");
            for (int i = 0; i < number; i++)
            {
                Console.WriteLine("Введите номер:");
                mobileNumbers.Add(Console.ReadLine());
            }
        }

        public static void ShowNumbers(List<string> mobileNumbers)
        {
            List<string> numbersWithoutCode = new List<string>();
            List<string> simpleNumbers = new List<string>();
            Numbers.ParseNumbers(mobileNumbers, numbersWithoutCode, simpleNumbers);
            Console.WriteLine("Полные мобильные номера телефонов:");
            if (mobileNumbers.Count != 0)
            {
                foreach (var mobile in mobileNumbers)
                {
                    Console.WriteLine(mobile);
                }
            }
            else
                Console.WriteLine("Пусто");
            Console.WriteLine("Номера телефонов без кода:");
            if (numbersWithoutCode.Count != 0)
            {
                foreach (var withoutCode in numbersWithoutCode)
                {
                    Console.WriteLine(withoutCode);
                }
            }
            else
                Console.WriteLine("Пусто");
            Console.WriteLine("Обычные номера(без кода страны и без кода оператора)");
            if (simpleNumbers.Count != 0)
            {
                foreach (var simple in simpleNumbers)
                {
                    Console.WriteLine(simple);
                }
            }
            else
                Console.WriteLine("Пусто");
        }
    }
}
