using System.ComponentModel.Design;
using System.Linq;
using System.Resources;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Students;
namespace StudentTest
{
    [TestClass]
    public class StudTest
    {
        [TestMethod]
        public void ScaleOfAverage()
        {
            //Arange    
            Student stud = new Student();
            double expected = 6;
            stud.Marks = new StudentMark[2]{new StudentMark(new Exam("math"),5 ),new StudentMark(new Exam("english"),7)};
            //Act
            double result = stud.Average;
            //Assert
            Assert.AreEqual(expected,result);


        }

        [TestMethod]
        public void ScaleOfAdditions()
        {
            int expected = 13;
            Student firstStudent = new Student();
            Student secondStudent = new Student();
            firstStudent.Marks = new StudentMark[2] { new StudentMark(new Exam("math"), 5), new StudentMark(new Exam("english"), 7) };
            secondStudent.Marks = new StudentMark[2] { new StudentMark(new Exam("math"), 8), new StudentMark(new Exam("english"), 6)};
            double result = firstStudent + secondStudent;
            Assert.AreEqual(expected, result);


        }

        [TestMethod]
        public void ScaleOfSubtraction()
        {

            int expected = -1;
            Student firstStudent = new Student();
            Student secondStudent = new Student();
            firstStudent.Marks = new StudentMark[2] { new StudentMark(new Exam("math"), 5), new StudentMark(new Exam("english"), 7) };
            secondStudent.Marks = new StudentMark[2] { new StudentMark(new Exam("math"), 8), new StudentMark(new Exam("english"), 6) };
            double result = firstStudent - secondStudent;
            Assert.AreEqual(expected, result);

        }



        [TestMethod]
        public void ScaleOfSResult()
        {

            int expected = 2;
            Student firstStudent = new Student();
            Student secondStudent = new Student();
            firstStudent.Marks = new StudentMark[2] { new StudentMark(new Exam("math"), 7), new StudentMark(new Exam("english"), 10) };
            secondStudent.Marks = new StudentMark[2] { new StudentMark(new Exam("math"), 8), new StudentMark(new Exam("english"), 5) };
            double result = firstStudent - secondStudent;
            Assert.AreEqual(expected, result);

        }




        [TestMethod]
        public void ScaleOfSResultTwo()
        {

            int expected = 18;
            Student firstStudent = new Student();
            Student secondStudent = new Student();
            firstStudent.Marks = new StudentMark[3] { new StudentMark(new Exam("math"), 10), new StudentMark(new Exam("english"), 10), new StudentMark(new Exam("russian"), 10) };
            secondStudent.Marks = new StudentMark[3] { new StudentMark(new Exam("math"), 8), new StudentMark(new Exam("english"), 6), new StudentMark(new Exam("russian"), 10) };
            double result = firstStudent + secondStudent;
            Assert.AreEqual(expected, result);

        }


        [TestMethod]
        public void ScaleOfSResultThree()
        {

            int expected = 2;
            Student firstStudent = new Student();
            Student secondStudent = new Student();
            firstStudent.Marks = new StudentMark[3] { new StudentMark(new Exam("math"), 10), new StudentMark(new Exam("english"), 10), new StudentMark(new Exam("russian"), 10) };
            secondStudent.Marks = new StudentMark[2] { new StudentMark(new Exam("english"), 6), new StudentMark(new Exam("russian"), 10) };
            double result = firstStudent - secondStudent;
            Assert.AreEqual(expected, result);

        }











    }
}
