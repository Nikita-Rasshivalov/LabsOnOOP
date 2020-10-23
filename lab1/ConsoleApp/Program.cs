using Figure;
using System;
using System.Runtime.ExceptionServices;

namespace ConsoleApp
{


    public class Program
    {
        /// <summary>
        /// Enter point
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Cordinates cordinates = new Cordinates();
            var trapezeInstance = new Trapeze();
            Menu menu = new Menu();
            int option = 0;
            double firstCordinate, secondCordinate;
            Console.WriteLine("Enter firstCordinate ");
            while (!double.TryParse(Console.ReadLine(), out firstCordinate))
                Console.WriteLine("Error");

            cordinates.firstCordinate = firstCordinate;

            Console.WriteLine("Enter secondCordinate ");
            while (!double.TryParse(Console.ReadLine(), out secondCordinate))
                Console.WriteLine("Error");

            cordinates.secondCordinate = secondCordinate;

            if (FigureValidator.CheckValidation(cordinates))
            {
                while (option != 5)
                {

                    option = menu.ShowMenu();
                    Console.Clear();
                    switch (option)
                    {
                        case 1:
                          var side = trapezeInstance.CalcSideLenght(cordinates);

                            Console.WriteLine($"{side[0]}  {side[1]}   {side[2]}   {Math.Round(side[3])}");
                            break;
                        case 2:
                           var sum = trapezeInstance.CalcPerimetr(cordinates);
                            Console.WriteLine("{0:##.##}", sum);
                            break;
                        case 3:

                            var square = trapezeInstance.CalcSquare(cordinates);
                            Console.WriteLine("{0:##.##}", square);

                            break;
                        case 4:
                            BeloningPoints.CheckPoints(cordinates);

                            break;
                        case 5:
                            break;
                        default:
                            Console.WriteLine("Incorrect number");
                            break;
                    }

                }


            }
        }
    }
}
