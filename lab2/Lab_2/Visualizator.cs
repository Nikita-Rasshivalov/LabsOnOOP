using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Students;

namespace UI
{
    public static class Visualizator
    {
        /// <summary>
        /// Method that shows menu
        /// </summary>
        /// <returns>option(number of choice)</returns>
        public static int ShowMenu()
        {
            int option, number;
            Console.WriteLine("1: Enter information about students.");
            Console.WriteLine("2: Which students to add/subtract ");
            Console.WriteLine("3: Display information about students");
            while (!Int32.TryParse(Console.ReadLine(), out number))
                Console.WriteLine("Error");
            option = number;
            return option;
        }




    }
}
