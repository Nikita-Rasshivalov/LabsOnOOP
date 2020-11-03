using System;
using Students;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;

namespace UI
{
    class Program
    {
        /// <summary>
        /// Point of entry program
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int option = 0;
            var average = new Student();
            var addStudents = new AddStudents();

            Console.WriteLine("Enter numbers of students");
            int numStud, numOfStudents;
            while (!Int32.TryParse(Console.ReadLine(), out numStud) || numStud < 1)
                Console.WriteLine("Error enter int number!");
            numOfStudents = numStud;
            Student[] student = new Student[numOfStudents];
            for (int i = 0; i < student.Length; i++)
            {
                student[i] = new Student();
            }
            Console.Clear();
            while (option != 5)
            {
                option = Visualizator.ShowMenu();
                Console.Clear();

                switch (option)
                {
                    case 1:
                        addStudents.EnterStudent(student);
                        addStudents.EnterExamsAndMarks(student);
                        break;
                    case 2:
                        bool exist = true;

                        for (int i = 0; i < student.Length; i++)
                        {
                            if (student[i].ExistanceMark == false)
                            {
                            exist = false;
                            }

                        }
                        if (exist == false)
                        {
                            Console.WriteLine("Not all students");
                        }
                        else
                        {
                            addStudents.PrintStudents(student);
                            addStudents.AddOrSubtract(student);

                        }
                        

                       
                        break;
                    case 3:
                        addStudents.PrintStudents(student);
                        break;

                }

            }




        }
    }
}
