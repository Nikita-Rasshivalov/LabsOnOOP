using System;
using OneDeminsionArray;

namespace UI
{
    /// <summary>
    /// Class working with arrays
    /// </summary>
    public class WorkingWithMassive
    {
        /// <summary>
        /// Array input method
        /// </summary>
        /// <returns>Massive</returns>
        public static Massive EnterArray()
        {

            Console.Write("Enter num of array elements: ");
            int numOfArray, num;
            while (!Int32.TryParse(Console.ReadLine(), out num) || num < 1)
                Console.WriteLine("!!!!Error. Please enter integer number");
            numOfArray = num;
            int[] array = new int[numOfArray];
            Console.Write("Elements: \n");
            for (int i = 0; i < numOfArray; i++)
            {
                while (!Int32.TryParse(Console.ReadLine(), out array[i]))
                    Console.WriteLine("!!!!Error. Please enter integer number");
                
            }

            return new Massive(array);

        }


        /// <summary>
        /// Array output method
        /// </summary>
        /// <param name="array">Array</param>
        public static void OutMassive(Massive array)
        {
            for (var i = 0; i < array.LengthOfMass; i++)
            {
                Console.Write($"{array[i]} ");
            }



        }


        /// <summary>
        /// Calc positive elements
        /// </summary>
        /// <param name="massives">Arrays</param>
        /// <returns>Count positive elements</returns>
        public static int CalcPositiveElements(params Massive[] massives)
        {
            int countPositiveElements = 0;
            for (int i = 0; i < massives.Length; i++)
            {
                for (int j = 0; j < massives[i].LengthOfMass; j++)
                {
                    if (massives[i][j] > 0)
                    {
                        countPositiveElements++;
                    }

                }

            }
            Console.WriteLine($"\nPositive elements = {countPositiveElements}");
            return countPositiveElements;
        }



        /// <summary>
        /// Check zero elements
        /// </summary>
        /// <param name="array">Array A</param>
        /// <returns>Yes or No zero elements</returns>
        public static bool CheckZeroElem(Massive array)
        {
            bool zeroElem = true;
            for (int i = 0; i < array.LengthOfMass; i++)
            {
                if (array[i] == 0)
                {
                    zeroElem = false;
                }

            }
            if (zeroElem == false)
            {
                Console.WriteLine("\nMassive has zero elements!");
            }
            else
            {
                Console.WriteLine("\nMassive has't zero elements!");
            }
            return zeroElem;
        }
        /// <summary>
        /// Increas massive
        /// </summary>
        /// <param name="array">Array </param>
        /// <returns>Increasing massive</returns>
        public static Massive AdditionOnIntegerNumber(Massive array)
        {
            Console.WriteLine("\nBy what number to increase? ");
            int number, increasingNum;
            while (!Int32.TryParse(Console.ReadLine(), out number))
                Console.WriteLine("Enter int number! ");
            increasingNum = number;

            for (int i = 0; i < array.LengthOfMass; i++)
            {
                array[i] += increasingNum;

            }
            return array;
        }

        /// <summary>
        /// Calc positive elements in massives after increase
        /// </summary>
        /// <param name="MassA">Array A</param>
        /// <param name="MassC">Array C</param>
        /// <returns>Count positive elements</returns>
        public static int CalcPositiveElemInMassAandMassCafterAddition(Massive MassA, Massive MassC)
        {
            int CountPositiveA = 0;
            int CountPositiveC = 0;
            int result = 0;



            for (int i = 0; i < MassA.LengthOfMass; i++)
            {
                MassA[i] += 5;
            }
            Console.WriteLine("\nMassA: ");
            CountPositiveA = CalcPositiveElements(MassA);

            for (int j = 0; j < MassC.LengthOfMass; j++)
            {
                MassC[j] += 2;
            }

            Console.WriteLine("MassC: ");
            CountPositiveC = CalcPositiveElements(MassC);

            result = CountPositiveA + CountPositiveC;

            return result;

        }


        /// <summary>
        /// Calc positive elements in massives after increase
        /// </summary>
        /// <param name="MassA">Array A</param>
        /// <param name="MassB">Array B</param>
        /// <param name="MassC">Array C</param>
        /// <returns>Count positive elements</returns>

        public static int CascPositiveElemInMassAandMassBandMassCafterAddition(Massive MassA, Massive MassB, Massive MassC)
        {
            int CountPositiveA = 0;
            int CountPositiveB = 0;
            int CountPositiveC = 0;
            int result = 0;

            Console.WriteLine("\nMassA: ");
            CountPositiveA = CalcPositiveElements(MassA);

            for (int k = 0; k < MassB.LengthOfMass; k++)
            {
                MassB[k] += 2;
            }


            Console.WriteLine("MassB: ");
            CountPositiveC = CalcPositiveElements(MassC);


            for (int j = 0; j < MassC.LengthOfMass; j++)
            {
                MassC[j] += 4;

            }

            Console.WriteLine("MassC ");
            CountPositiveC = CalcPositiveElements(MassC);
            result = CountPositiveA + CountPositiveB + CountPositiveC;

            return result;

        }

        /// <summary>
        /// Replase zero elements
        /// </summary>
        /// <param name="MassA">Array A</param>
        /// <param name="MassB">Array B</param>
        /// <returns>Massive without zero elements</returns>
        public static Massive ReplaceZeroElements(Massive MassA, Massive MassB)
        {

            int average = CalcAverage(MassA);
            Console.Write("MassA: ");
            bool ZeroElemA = CheckZeroElem(MassA);
            Console.Write("MassB: ");
            bool ZeroElemB = CheckZeroElem(MassB);
            Console.Write("Count positeve elem in mass A:");
            int countPositiveElemA = CalcPositiveElements(MassA);


            for (int i = 0; i < MassA.LengthOfMass; i++)
            {
                if (ZeroElemA == true && countPositiveElemA > 3 && ZeroElemB == false)
                {
                    if (MassB[i] == 0)
                    {
                        MassB[i] = CalcAverage(MassA);
                    }
                }

            }

            Console.WriteLine($"Average: {average}");

            return MassB;
        }

        /// <summary>
        /// Calc average
        /// </summary>
        /// <param name="array">Array </param>
        /// <returns>Average</returns>
        public static int CalcAverage(Massive array)
        {
            int average = 0;
            int sum = 0;
            for (int i = 0; i < array.LengthOfMass; i++)
            {
                sum += array[i];
            }
            average = sum / array.LengthOfMass;

            return average;
        }

    }
}