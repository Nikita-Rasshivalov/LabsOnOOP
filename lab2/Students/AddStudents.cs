using System;



namespace Students
{
    /// <summary>
    /// Class additions of students
    /// </summary>
    public class AddStudents
    {
        /// <summary>
        /// Student input method
        /// </summary>
        /// <param name="student"></param>
        /// <returns>Students(First Second Third name</returns>
        public Student[] EnterStudent(Student[] student)
        {

            for (int i = 0; i < student.Length; i++)
            {

                student[i] = new Student
                {

                    SecondName = TableExam.EnterSecondName(),
                    FirstName = TableExam.EnterFirstName(),
                    ThirdName = TableExam.EnterThirdName()
                };
            }

            return student;
        }

        /// <summary>
        /// Exams and Marks input method
        /// </summary>
        /// <param name="student"></param>
        public void EnterExamsAndMarks(Student[] student)
        {
            Console.Clear();
            Console.WriteLine("Enter num of exams");
            int numOfExams;
            int numExam;

            while (!Int32.TryParse(Console.ReadLine(), out numExam) || numExam < 1)
                Console.WriteLine("Error");
            numOfExams = numExam;

            for (int i = 0; i < student.Length; i++)
            {
                student[i].Marks = new StudentMark[numOfExams];
            }

            int countExams = 0;
            for (int i = 0; i < numOfExams; i++)
            {
                Console.WriteLine("Enter name of exam");
                string name;
                int mark;
                name = Console.ReadLine();
                foreach (Student stud in student)
                {
                    stud.Marks[countExams] = new StudentMark();
                    stud.Marks[countExams].Exam = new Exam(name);
                    Console.WriteLine($"{stud.FirstName} {stud.SecondName} {stud.ThirdName}");
                    Console.WriteLine("Enter mark on exam");
                    while (!Int32.TryParse(Console.ReadLine(), out mark) || mark <1 || mark > 10 )
                        Console.WriteLine("Error");
                    stud.Marks[countExams].Mark = mark;
                    

                    
                }
                countExams++;
                Console.Clear();
            }
        }
        /// <summary>
        /// Method of print information about student
        /// </summary>
        /// <param name="student"></param>
        public void PrintStudents(Student[] student)
        {
            int count = 0;
            Console.Clear();
            foreach (var stud in student)
            {
                count++;
                Console.Write($" {count} {stud.SecondName} {stud.FirstName} {stud.ThirdName}    \t  |");
                foreach (var studMark in stud.Marks)
                {
                    Console.Write($"{studMark.Exam.NameOfExam} / {studMark.Mark} | ");

                }

                Console.WriteLine();

            }
        }


        /// <summary>
        /// Addition and subtraction method of types 
        /// </summary>
        /// <param name="student"></param>
        public void AddOrSubtract(Student[] student)
        {
            Console.WriteLine("What to do?  1 - to add(cложить): 2-subtract(отнять)");
            int num, choice;
            int studOne, studTwo, st1,st2;
            while (!Int32.TryParse(Console.ReadLine(), out num ))
                Console.WriteLine("Error");
            choice = num;
            Console.WriteLine("Enter numbers of student");
            while (!Int32.TryParse(Console.ReadLine(), out st1))
                Console.WriteLine("Error");
            studOne = st1;
            while (!Int32.TryParse(Console.ReadLine(), out st2))
                Console.WriteLine("Error");
            studTwo = st2;
            if (studOne <= student.Length && studOne > 0 && studTwo <= student.Length && studTwo > 0)
            {
                double result;
                switch (choice)
                {
                    case 1:
                        result = student[studOne - 1] + student[studTwo - 1];
                        Console.WriteLine(result);
                        break;
                    case 2:
                        result = student[studOne - 1] - student[studTwo - 1];
                        Console.WriteLine(result);
                        break;
                    default:
                        Console.WriteLine("Incorrect choice");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Incorrect number of student");
            }

        }

    }

}