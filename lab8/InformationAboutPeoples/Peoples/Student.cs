using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peoples
{
    /// <summary>
    /// Class Student
    /// </summary>
    public class Student : Human
    {
     

        /// <summary>
        ///  Create  an instance of the Student
        /// </summary>
        /// <param name="secondName">Second name</param>
        /// <param name="status">Status</param>
        /// <param name="birth">Birth</param>
        public Student(string secondName, StatusOfHuman status, int birth,int[] load) : base(secondName,status,birth, load)
        {

        }


        /// <summary>
        ///  Override method Svedenija
        /// </summary>
        /// <returns>Average value of marks</returns>
        public override double Svedenija()
        {
            int sum = 0;
            double average = 0;
            for (int i = 0; i < load.Length; i++)
            {
                sum = sum + load[i];
            }
            average = sum / load.Length;
            return average;
        }
        /// <summary>
        /// Override method GetInfo
        /// </summary>
        /// <returns>info</returns>
        public override string GetInfo()
        {
            double average = Svedenija();
            string info = $"{secondName} {status} {birth} {average}";
            return info;
        }
    }
}
