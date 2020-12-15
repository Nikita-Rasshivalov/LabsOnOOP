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
        /// status
        /// </summary>
        private StatusOfHuman status = StatusOfHuman.Student;
        public override StatusOfHuman Status { get { return status; } }

        /// <summary>
        ///  Create  an instance of the Student
        /// </summary>
        /// <param name="secondName">Second name</param>
        /// <param name="birth">Birth</param>
        public Student(string secondName,  int birth,int[] load) : base(secondName,birth, load)
        {

        }
        /// <summary>
        /// ConvertToString
        /// </summary>
        /// <param name="load">load</param>
        /// <returns>loads</returns>
        public override string ConvertToString(int[] load)
        {
            string loads = "";

            foreach (var i in load)
            {
                loads = loads + " " + i.ToString();
            }
            loads += " (Marks) ";            
            return loads;
        }

        /// <summary>
        /// GetMoreInfo
        /// </summary>
        /// <param name="load">load</param>
        /// <returns>Count marks more or exactly 9</returns>
        public override int GetMoreInfo(int[] load)
        {
            int count = 0;
          
            for (int i = 0; i < load.Length; i++)
            {
                if (load[i] > 8)
                {
                    count++;
                }
            }
            return count;
        }
        /// <summary>
        /// Indexator
        /// </summary>
        /// <param name="nameOfDiscipline">nameOfDiscipline</param>
        /// <returns></returns>
        public override int this[string nameOfDiscipline] { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
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
            string info = $"{secondName} {Status} {YearsOld} | {average} {"(Average mark)"}";
            return info;
        }
    }
}
