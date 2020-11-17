using System;
using System.Collections.Generic;
using System.Text;

namespace UI
{
    /// <summary>
    /// User Interface
    /// </summary>
    public static class ShowMenu
    {
        /// <summary>
        /// Show menu
        /// </summary>
        /// <returns>number of menu</returns>
        public static int Menu()
        {
            int option, number;
            Console.WriteLine("\n1: Show massives ");
            Console.WriteLine("2: Check positive elements  ");
            Console.WriteLine("3: Increase massives on int number ");
            Console.WriteLine("4: Check zero elements ");
            Console.WriteLine("5: To Count positeve elements in Massive A and C after addition");
            Console.WriteLine("6: To Count positeve elements in Massive A and B and C after addition");
            Console.WriteLine("7: Replace zero elements in massive B on averega of massive A");
            Console.WriteLine("8: Exit");
            while (!Int32.TryParse(Console.ReadLine(), out number)||number<0 || number>8)
                Console.WriteLine("!!Error: Enter int exist number");
            option = number;
            return option;
        }
    }
}
