using System;

namespace OneDeminsionArray
{
    /// <summary>
    /// Class massive
    /// </summary>
    public class Massive
    {
        private int[] array;
        /// <summary>
        /// Indexator
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public int this[int index]
        {
            get
            {
                return array[index];
            }
            set { array[index] = value; }
        }
        public int LengthOfMass
        {
            get { return array.Length; }
        }

        public Massive(int[] array)
        {
            this.array = array;
        }

        public Massive(Massive array)
        {

        }

        /// <summary>
        /// Operator overloading
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>

        public static bool operator true(Massive array)
        {
            for (int i = 0; i < array.LengthOfMass; i++)

                if (array[i] == 0)
                {
                    return false;
                }

            return true;
        }
        /// <summary>
        /// Operator overloading
        /// </summary>
        /// <param name="array"></param>
        /// <
        public static bool operator false(Massive array)
        {
            for (int i = 0; i < array.LengthOfMass; i++)

                if (array[i] == 0)
                {
                    return true;
                }
            return false;
        }



        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            else
            {
                Massive checkCalc = (Massive)obj;
                if (LengthOfMass != checkCalc.LengthOfMass)
                {
                    return false;
                }
                else
                {
                    for (int i = 0; i < LengthOfMass; i++)
                    {
                        if (array[i] != checkCalc.array[i])
                            return false;
                    }
                }
            }
            return true;
        }

        /// <summary>
        /// Redefining the GetHashCode method that calculates the hash code of the current object
        /// </summary>
        /// <returns>Hash code of the current object</returns>

        public override int GetHashCode()
        {
            return array.Length / 2;
        }



    }
}