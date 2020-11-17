using System;
using OneDeminsionArray;


namespace UI
{
    class Program
    {
        /// <summary>
        ///     General program
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {


            int numOfMas;
            Console.WriteLine("Enter num of massives");
            while (!Int32.TryParse(Console.ReadLine(), out numOfMas) || numOfMas < 1)
                Console.WriteLine("!!!!Enter int num");

            Massive[] mass = new Massive[numOfMas];

            for (int i = 0; i < numOfMas; i++)
            {
                Console.WriteLine($"Massive {i + 1}:");
                mass[i] = WorkingWithMassive.EnterArray();
            }

            int option = 0;
            Console.Clear();
            while (option != 8)
            {
                option = ShowMenu.Menu();
                Console.Clear();

                switch (option)
                {
                    case 1:

                        for (int i = 0; i < numOfMas; i++)
                        {
                            Console.Write($"\nMassive {i + 1}: ");
                            WorkingWithMassive.OutMassive(mass[i]);

                        }

                        break;
                    case 2:
                        int positive = 0;
                        int allPositive = 0;

                        for (int i = 0; i < numOfMas; i++)
                        {
                            Console.Write($"\nMassive {i + 1}: ");
                            WorkingWithMassive.OutMassive(mass[i]);
                            positive = WorkingWithMassive.CalcPositiveElements(mass[i]);
                            allPositive += positive;
                        }

                        Console.WriteLine($"\nAll positive elements: {allPositive} ");

                        break;
                    case 3:

                        for (int i = 0; i < numOfMas; i++)
                        {
                            Console.Write($"\nMassive {i + 1}: ");
                            WorkingWithMassive.OutMassive(mass[i]);
                            WorkingWithMassive.AdditionOnIntegerNumber(mass[i]);
                            Console.Write($"\nMassive {i + 1}: ");
                            WorkingWithMassive.OutMassive(mass[i]);
                        }

                        break;
                    case 4:
                        for (int i = 0; i < numOfMas; i++)
                        {
                            Console.Write($"\nMassive {i + 1}: ");
                            WorkingWithMassive.OutMassive(mass[i]);
                            WorkingWithMassive.CheckZeroElem(mass[i]);
                        }
                        break;
                    case 5:

                        break;
                    case 6:

                        break;
                    case 7:

                        break;
                    default:
                        break;


                }

            }


        }
    }
}
