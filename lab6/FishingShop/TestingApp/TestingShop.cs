using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShopFishing;
using UserInterface;

namespace TestingApp
{
    [TestClass]
    public class TestingShop
    {
        [TestMethod]
        public void GetNumberFishingRod()
        {
            //Arange
            int price = 2;
            int expected = 1;
            List<DayInfo> day = new List<DayInfo>();
            DayInfo.InfoAboutPurchase FishingRod = new DayInfo.InfoAboutPurchase(FishingThings.FishingRod,
                new DateTime(2020, 10, 25), FishingType.Autumn, price);
            DayInfo.InfoAboutPurchase Fider = new DayInfo.InfoAboutPurchase(FishingThings.Fider,
                new DateTime(2020, 10, 25), FishingType.Autumn, price);
            DayInfo.InfoAboutPurchase Spinning = new DayInfo.InfoAboutPurchase(FishingThings.Spinning,
                new DateTime(2020, 10, 25), FishingType.Spring, price);
            DayInfo.AddThings(day, FishingRod);
            DayInfo.AddThings(day, Fider);
            DayInfo.AddThings(day, Spinning);
            //Act
            int result = DayInfo.GetNumber(day, FishingThings.FishingRod);
            //Assert
            Assert.AreEqual(expected, result);
        }


        [TestMethod]
        public void GetNumberSpinning()
        {
            //Arange
            int price = 2;
            int expected = 2;
            List<DayInfo> day = new List<DayInfo>();
            DayInfo.InfoAboutPurchase FishingRod = new DayInfo.InfoAboutPurchase(FishingThings.FishingRod,
                new DateTime(2020, 10, 25), FishingType.Autumn, price);
            DayInfo.InfoAboutPurchase Fider = new DayInfo.InfoAboutPurchase(FishingThings.Fider,
                new DateTime(2020, 10, 25), FishingType.Autumn, price);
            DayInfo.InfoAboutPurchase Spinning = new DayInfo.InfoAboutPurchase(FishingThings.Spinning,
                new DateTime(2020, 10, 25), FishingType.Spring, price);
            DayInfo.InfoAboutPurchase Spinning2 = new DayInfo.InfoAboutPurchase(FishingThings.Spinning,
                new DateTime(2020, 10, 25), FishingType.Spring, price);
            DayInfo.AddThings(day, FishingRod);
            DayInfo.AddThings(day, Fider);
            DayInfo.AddThings(day, Spinning);
            DayInfo.AddThings(day, Spinning2);
            //Act
            int result = DayInfo.GetNumber(day, FishingThings.Spinning);
            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void GetNumberFider()
        {
            //Arange
            int price = 1;
            int expected = 1;
            List<DayInfo> day = new List<DayInfo>();
            DayInfo.InfoAboutPurchase FishingRod = new DayInfo.InfoAboutPurchase(FishingThings.FishingRod,
                new DateTime(2020, 10, 25), FishingType.Autumn, price);
            DayInfo.InfoAboutPurchase Fider = new DayInfo.InfoAboutPurchase(FishingThings.Fider,
                new DateTime(2020, 10, 25), FishingType.Autumn, price);
            DayInfo.InfoAboutPurchase Spinning = new DayInfo.InfoAboutPurchase(FishingThings.Spinning,
                new DateTime(2020, 10, 25), FishingType.Spring, price);
            DayInfo.InfoAboutPurchase Spinning2 = new DayInfo.InfoAboutPurchase(FishingThings.Spinning,
                new DateTime(2020, 10, 25), FishingType.Spring, price);
            DayInfo.AddThings(day, FishingRod);
            DayInfo.AddThings(day, Fider);
            DayInfo.AddThings(day, Spinning);
            DayInfo.AddThings(day, Spinning2);
            //Act
            int result = DayInfo.GetNumber(day, FishingThings.Fider);
            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void GetNumberPicker()
        {
            //Arange
            int price = 0;
            int expected = 1;
            List<DayInfo> day = new List<DayInfo>();
            DayInfo.InfoAboutPurchase FishingRod = new DayInfo.InfoAboutPurchase(FishingThings.FishingRod,
                new DateTime(2020, 10, 25), FishingType.Autumn, price);
            DayInfo.InfoAboutPurchase Fider = new DayInfo.InfoAboutPurchase(FishingThings.Fider,
                new DateTime(2020, 10, 25), FishingType.Autumn, price);
            DayInfo.InfoAboutPurchase Spinning = new DayInfo.InfoAboutPurchase(FishingThings.Spinning,
                new DateTime(2020, 10, 25), FishingType.Spring, price);
            DayInfo.InfoAboutPurchase Spinning2 = new DayInfo.InfoAboutPurchase(FishingThings.Spinning,
                new DateTime(2020, 10, 25), FishingType.Spring, price);

            DayInfo.AddThings(day, FishingRod);
            DayInfo.AddThings(day, Fider);
            DayInfo.AddThings(day, Spinning);
            DayInfo.AddThings(day, Spinning2);
            //Act
            int result = DayInfo.GetNumber(day, FishingThings.Fider);
            //Assert
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void AddPurchae()
        {
            //Arange
            int expected = 1;
            int price = 1;
            List<DayInfo> days = new List<DayInfo>() { new DayInfo(new DateTime(2020, 10, 20), new List<DayInfo.InfoAboutPurchase>() { new DayInfo.InfoAboutPurchase() }) };
            DayInfo.InfoAboutPurchase purchase = new DayInfo.InfoAboutPurchase(FishingThings.Picker, new DateTime(2020, 10, 20), FishingType.Autumn, price);
            //Act
            DayInfo.AddThings(days, purchase);
            int result = days.Count;
            //Assert
            Assert.AreEqual(expected, result);
        }
    }
}
