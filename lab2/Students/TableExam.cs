using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students
{
    /// <summary>
    /// 
    /// </summary>
    public static class TableExam
    {
        /// <summary>
        /// Firstname input method
        /// </summary>
        /// <returns>Firstname</returns>
        public static string EnterFirstName()
        {
            Student student = new Student();
            Console.WriteLine("Enter FirstName of student : ");
            student.FirstName = Convert.ToString(Console.ReadLine());
            return student.FirstName;
        }
        /// <summary>
        /// Second name input method
        /// </summary>
        /// <returns>Second name</returns>
        public static string EnterSecondName()
        {
            Student student = new Student();
            Console.WriteLine("Enter SecondName of student : ");
            student.SecondName = Convert.ToString(Console.ReadLine());
            return student.SecondName;
        }
        /// <summary>
        /// Third name input method
        /// </summary>
        /// <returns>Third name</returns>
        public static string EnterThirdName()
        {
            Student student = new Student();
            Console.WriteLine("Enter ThirdName of student : ");
            student.ThirdName = Convert.ToString(Console.ReadLine());
            return student.ThirdName;
        }

     
   

    }
}
