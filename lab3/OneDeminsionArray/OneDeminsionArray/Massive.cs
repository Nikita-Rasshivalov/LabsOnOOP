using System;

namespace OneDeminsionArray
{
    /// <summary>
    /// Class massive
    /// </summary>
    public class Massive
    {   /// <summary>
        ///     Arrays of integer numbers
        /// </summary>
        private int[] array;
        /// <summary>
        /// Indexator
        /// </summary>
        /// <param name="index">index</param>
        /// <returns>Value of index</returns>
        public int this[int index]
        {
            get
            {
                return array[index];
            }
            set { array[index] = value; }
        }/// <summary>
        /// Property that returns length of array
        /// </summary>
        public int LengthOfMass
        {
            get { return array.Length; }
        }
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="array">Array</param>
        public Massive(int[] array)
        {
            this.array = array;
        }
        /// <summary>
        /// Empty constructor
        /// </summary>
        /// <param name="array">Array</param>
        public Massive(Massive array)
        {

        }

        /// <summary>
        /// Operator overloading
        /// </summary>
        /// <param name="array">Array of integer numbers elemets</param>
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
        /// <param name="array">Array of integer numbers elemets</param>
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

        /// <summary>
        /// Redefining the Equals method
        /// </summary>
        /// <param name="obj">Array of integer numbers elemets </param>
        /// <returns>True if the specified object is equal to the current object; otherwise, false</returns>

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