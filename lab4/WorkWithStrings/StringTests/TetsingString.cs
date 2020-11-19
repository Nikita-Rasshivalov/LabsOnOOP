using System;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WorkWithStrings;
namespace StringTests
{
    [TestClass]
    public class TetsingString
    {
        [TestMethod]
        public void CheckDuplicateWords()
        {
            //Arange
            string initialString = "привет привет привет";
            string expected = "Неверно введена строка";
            //Act
            string result = Words.DelRepeatedWord(initialString);
            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void CheckDuplicateWords_2()
        {
            //Arange
            string initialString = "привет привет привет!";
            string expected = "привет! ";
            //Act
            string result = Words.DelRepeatedWord(initialString);
            //Assert
            Assert.AreEqual(expected, result);
        }


        [TestMethod]
        public void CheckDuplicateWords_3()
        {
            //Arange
            string initialString = "Hello";
            string expected = "Неверно введена строка";
            //Act
            string result = Words.DelRepeatedWord(initialString);
            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void CheskAdressAndDate()
        {
            //Arange
            string[] initialString = { "vk.com 24.12.2002 16-59" };
         
            bool expected = true;
            //Act
            bool result = Words.CheckAdressAndDate(initialString);
            //Assert
            Assert.AreEqual(expected, result);
        }


    
      
    }
}
