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

        public Student(string FirstName, string SecondName, string Patronymic)
        {
            this.SecondName = SecondName;
            this.FirstName = FirstName;
            this.Patronymic = Patronymic;
        }


        /// <summary>
        /// Stud marks
        /// </summary>

        public StudentMark[] Marks;

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




        /// <summary>
        /// overload addition
        /// </summary>
        /// <param name="firstStudent">First student</param>
        /// <param name="secondStudent">Second student</param>
        /// <returns>result of additions averages values of exam of students</returns>
        /*  public static double operator +(Student firstStudent, Student secondStudent)
          {
              double result = firstStudent.Average + secondStudent.Average;
              return result;
          }*/

        /// <summary>
        /// overload subtraction
        /// </summary>
        /// <param name="firstStudent">First student</param>
        /// <param name="secondStudent">Second student</param>
        /// <returns>result of subtractions averages values of exam of students</returns>
        /*    public static double operator -(Student firstStudent, Student secondStudent)
            {
                double result = firstStudent.Average - secondStudent.Average;
                return result;
            }*/


    }






}
