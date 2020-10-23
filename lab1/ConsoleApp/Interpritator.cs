using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{/// <summary>
 /// Normal menu class
/// </summary>
    public class Menu
    {/// <summary>
     /// Method calling the menu
     /// </summary>
     /// <returns>return  number of menu</returns>
        public int ShowMenu()
        {
            int option,number;
            Console.WriteLine("Press key...");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("\n1.Lengths of the trapeze sides");
            Console.WriteLine("2.The perimetr of a trapeze");
            Console.WriteLine("3.Square of a trapeze");
            Console.WriteLine("4.Belonging point");
            Console.WriteLine("5.Exit");
            Console.WriteLine("\nSelect item: ");
            while (!Int32.TryParse(Console.ReadLine(), out option))
                Console.WriteLine("Error");

            number = option;
                
            return number;
        }
    }
}
