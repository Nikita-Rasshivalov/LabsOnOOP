using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students
{
    public class Student
    {
        
        /// <summary>
        /// 
        /// </summary>
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string ThirdName { get; set; }

        public StudentMark[] Marks;
        /// <summary>
        /// Method for obtaining average value
        /// </summary>
        public double Average { get { return GetAverage(); } }
        double GetAverage()
        {
            double sum = 0;
            
            foreach (var studMark in Marks)
                sum += studMark.Mark;

            double average = sum / Marks.Length;
            return average;
        }


        /// <summary>
        /// overload addition
        /// </summary>
        /// <param name="firstStudent"></param>
        /// <param name="secondStudent"></param>
        /// <returns>result of additions averages values of exam of students</returns>
        public static double operator +(Student firstStudent, Student secondStudent)
        {
            double result = firstStudent.Average + secondStudent.Average;
            return result;
        }

        /// <summary>
        /// overload subtraction
        /// </summary>
        /// <param name="firstStudent"></param>
        /// <param name="secondStudent"></param>
        /// <returns>result of subtractions averages values of exam of students</returns>
        public static double operator -(Student firstStudent, Student secondStudent)
        {
            double result = firstStudent.Average - secondStudent.Average;
            return result;
        }


    }






}
