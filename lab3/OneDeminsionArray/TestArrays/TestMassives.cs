using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UI;
using OneDeminsionArray;


namespace TestArrays
{
    [TestClass]
    public class TestMassives
    {
        [TestMethod]
        public void CalculatePositiveElements()
        {
            double expected = 5;
            int[] arr = new int[5] { 1, 2, 3, 4, 5 };
            Massive array = new Massive(arr);


            double result = WorkingWithMassive.CalcPositiveElements(array);


            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void CalculatePositiveElements2()
        {
            double expected = 3;
            int[] arr = new int[5] { 1, -1, 0, 4, 5 };
            Massive array = new Massive(arr);


            double result = WorkingWithMassive.CalcPositiveElements(array);


            Assert.AreEqual(expected, result);
        }


        [TestMethod]
        public void CheckZeroElem()
        {
            bool expected = false;
            int[] arr = new int[5] { 1, 2, 0, 4, 5 };
            Massive array = new Massive(arr);


            bool result = WorkingWithMassive.CheckZeroElem(array);


            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void CheckZeroElem2()
        {
            bool expected = true;
            int[] arr = new int[5] { 1, 2, 1, 4, 5 };
            Massive array = new Massive(arr);


            bool result = WorkingWithMassive.CheckZeroElem(array);


            Assert.AreEqual(expected, result);
        }


        [TestMethod]
        public void CheckAddition()
        {
            int[] newArr = new int[5] { 2, 2, 2, 2, 2 };

            Massive expected = new Massive(newArr);

            int[] arr = new int[5] { 1, 1, 1, 1, 1, };
            Massive array = new Massive(arr);


            Massive result = WorkingWithMassive.AdditionOnIntegerNumber(array);


            Assert.AreEqual(expected, result);
        }









    }
}
