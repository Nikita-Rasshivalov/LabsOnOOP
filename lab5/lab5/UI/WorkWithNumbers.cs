using System;
using System.Collections.Generic;
using PhoneNumbers;

namespace UI
{
    /// <summary>
    /// Class for work with mobilenumbers
    /// </summary>
    public static class WorkWithNumbers
    {
        /// <summary>
        /// Method of entering mobile numbers
        /// </summary>
        /// <param name="mobileNumbers">Mobile numbers</param>
        public static void EnterNumbers(List<string> mobileNumbers)
        {
            Console.WriteLine("Сколько добавить номеров?");
            int number;
            while (!Int32.TryParse(Console.ReadLine(), out number) | number < 1)
                Console.WriteLine("Количество номеров не может быть меньше 1 и должны ровняться целому числу!!");
            Console.Clear();
            Console.Write("Пример ввода:+37529(33)(44)(25)1111111 или 29(33)(44)(25)1111111 или 1111111  \n");
            for (int i = 0; i < number; i++)
            {
                Console.WriteLine("Введите номер:");
                mobileNumbers.Add(Console.ReadLine());
            }
        }

        /// <summary>
        /// Method of showing mobile numbers
        /// </summary>
        /// <param name="mobileNumbers">Mobile numbers</param>
        public static void ShowNumbers(List<string> mobileNumbers)
        {
            List<string> fullNumbers = new List<string>();
            List<string> numbersWithoutCode = new List<string>();
            List<string> simpleNumbers = new List<string>();
            Numbers.ParseNumbers(mobileNumbers, fullNumbers, numbersWithoutCode, simpleNumbers);

            Console.WriteLine("Полные мобильные номера телефонов:");
            if (fullNumbers.Count != 0)
            {
                foreach (var mobile in fullNumbers)
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
