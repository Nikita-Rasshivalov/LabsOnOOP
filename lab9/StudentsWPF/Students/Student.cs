using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students
{
    /// <summary>
    /// Class student
    /// </summary>
    public class Student
    {

        /// <summary>
        /// First name
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// Second name
        /// </summary>
        public string SecondName { get; set; }
        /// <summary>
        /// Middle name
        /// </summary>
        public string Patronymic { get; set; }
        /// <summary>
        /// Mark existnance
        /// </summary>

        public Student(string firstName, string secondName, string patronymic)
        {
            this.SecondName = secondName;
            this.FirstName = firstName;
            this.Patronymic = patronymic;
            Marks = new List<StudentMark>();

        }


        /// <summary>
        /// Stud marks
        /// </summary>

        public List<StudentMark> Marks { get; set; }

        /// <summary>
        /// Method for obtaining average value
        /// </summary>
/*        public double Average
        {
            get
            {
                return GetAverage();
            
            }
        }*/
        /// <summary>
        /// Get acerage
        /// </summary>
        /// <returns>average</returns>

/*        double GetAverage()
        {

            double sum = 0;
            foreach (var studMark in Marks)
                sum += studMark.Mark;

            double average = sum / Marks.Length;
            return average;
        }*/
    }
}
