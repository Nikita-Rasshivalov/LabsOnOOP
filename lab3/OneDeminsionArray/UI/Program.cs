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
            Console.WriteLine("Enter massives ");
            Console.WriteLine("Massive A");
            Massive MassA = WorkingWithMassive.EnterArray();
            Console.WriteLine("Massive B");
            Massive MassB = WorkingWithMassive.EnterArray();
            Console.WriteLine("Massive C");
            Massive MassC = WorkingWithMassive.EnterArray();
            int option = 0;

            Console.Clear();
            while (option != 8)
            {
                option = ShowMenu.Menu();
                Console.Clear();

                switch (option)
                {
                    case 1:
                        Console.WriteLine("\nMassive A");
                        WorkingWithMassive.OutMassive(MassA);
                        Console.WriteLine("\nMassive B");
                        WorkingWithMassive.OutMassive(MassB);
                        Console.WriteLine("\nMassive C");
                        WorkingWithMassive.OutMassive(MassC);
                        break;
                    case 2:
                        Console.WriteLine("\nMassive A");
                        WorkingWithMassive.OutMassive(MassA);
                        Console.WriteLine("\nMassive B");
                        WorkingWithMassive.OutMassive(MassB);
                        Console.WriteLine("\nMassive C");
                        WorkingWithMassive.OutMassive(MassC);
                        Console.WriteLine("\n");

                        WorkingWithMassive.CalcPositiveElements(MassA, MassB, MassC);
                        break;
                    case 3:

                        Console.WriteLine("Enter massive which you want to increase: ");

                        Console.WriteLine("\n 1: Massive A");
                        WorkingWithMassive.OutMassive(MassA);
                        Console.WriteLine("\n 2: Massive B");
                        WorkingWithMassive.OutMassive(MassB);
                        Console.WriteLine("\n 3: Massive C");
                        WorkingWithMassive.OutMassive(MassC);
                        Console.WriteLine("\nNumber: ");

                        int number, num;
                        while (!Int32.TryParse(Console.ReadLine(), out num) || num > 3)
                            Console.WriteLine("!!!!Enter existance massive");
                        number = num;

                        switch (number)
                        {
                            case 1:
                                WorkingWithMassive.AdditionOnIntegerNumber(MassA);
                                Console.WriteLine("New massiveA: ");
                                WorkingWithMassive.OutMassive(MassA);
                                break;
                            case 2:
                                WorkingWithMassive.AdditionOnIntegerNumber(MassB);
                                Console.WriteLine("New massiveB: ");
                                WorkingWithMassive.OutMassive(MassB);
                                break;
                            case 3:
                                WorkingWithMassive.AdditionOnIntegerNumber(MassC);
                                Console.WriteLine("New massiveC: ");
                                WorkingWithMassive.OutMassive(MassC);
                                break;
                        }
                        break;
                    case 4:
                        Console.WriteLine("What massive to check?");
                        int value, checkValue;
                        while (!Int32.TryParse(Console.ReadLine(), out checkValue))
                            Console.WriteLine("!!!!Enter existance massive");
                        value = checkValue;
                        switch (value)
                        {
                            case 1:
                                WorkingWithMassive.OutMassive(MassA);
                                WorkingWithMassive.CheckZeroElem(MassA);
                                break;
                            case 2:
                                WorkingWithMassive.OutMassive(MassB);
                                WorkingWithMassive.CheckZeroElem(MassB);
                                break;
                            case 3:
                                WorkingWithMassive.OutMassive(MassC);
                                WorkingWithMassive.CheckZeroElem(MassB);
                                break;
                        }
                        break;
                    case 5:
                        Console.WriteLine("\n 1: Massive A");
                        WorkingWithMassive.OutMassive(MassA);
                        Console.WriteLine("\n 2: Massive B");
                        WorkingWithMassive.OutMassive(MassB);
                        Console.WriteLine("\n 3: Massive C");
                        WorkingWithMassive.OutMassive(MassC);
                        var resultOfAddingMassivesAB = WorkingWithMassive.CalcPositiveElemInMassAandMassCafterAddition(MassA, MassC);
                        Console.WriteLine($"Count positive elements: {resultOfAddingMassivesAB}");
                        break;
                    case 6:
                        Console.WriteLine("\n 1: Massive A");
                        WorkingWithMassive.OutMassive(MassA);
                        Console.WriteLine("\n 2: Massive B");
                        WorkingWithMassive.OutMassive(MassB);
                        Console.WriteLine("\n 3: Massive C");
                        WorkingWithMassive.OutMassive(MassC);
                        var resultOfAddingMassivesABC = WorkingWithMassive.CascPositiveElemInMassAandMassBandMassCafterAddition(MassA, MassB, MassC);
                        Console.WriteLine($"Count positive elements: {resultOfAddingMassivesABC}");
                        break;
                    case 7:
                        WorkingWithMassive.ReplaceZeroElements(MassA, MassB);
                        WorkingWithMassive.OutMassive(MassB);
                        break;
                    default:
                        break;


                }

            }


        }
    }
}
