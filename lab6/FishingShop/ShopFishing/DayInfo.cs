using System;
using System.Collections.Generic;
using System.Linq;

namespace ShopFishing
{

    /// <summary>
    /// The enumeration representing fishing things
    /// </summary>
    public enum FishingThings
    {
        FishingRod,
        Spinning,
        Fider,
        Picker
    }

    /// <summary>
    ///The enumeration representing type of fishing
    /// </summary>
    public enum FishingType
    {
        Summer,
        Winter,
        Autumn,
        Spring

    }


    /// <summary>
    /// Information of the day
    /// </summary>
    public class DayInfo
    {
        /// <summary>
        /// Information about purchases
        /// </summary>
        public class InfoAboutPurchase
        {
            /// <summary>
            /// FishingType
            /// </summary>
            public FishingType FishingType { get; set; }
            /// <summary>
            /// Date
            /// </summary>
            public DateTime Date { get; set; }
            /// <summary>
            /// ThingType
            /// </summary>

            public FishingThings ThingType { get; set; }
            /// <summary>
            /// Price
            /// </summary>
            public int Price { get; set; }

            /// <summary>
            /// Create  an instance of the purchases
            /// </summary>
            /// <param name="thingType">thingType</param>
            /// <param name="date">date</param>
            /// <param name="fishingtype"fishingtype></param>
            /// <param name="price">price</param>
            public InfoAboutPurchase(FishingThings thingType, DateTime date, FishingType fishingtype, int price)
            {
                Date = date;
                ThingType = thingType;
                FishingType = fishingtype;
                Price = price;
            }

            /// <summary>
            /// Creates an instance of the purchases
            /// </summary>
            public InfoAboutPurchase()
            {

            }
        }

        /// <summary>
        /// Purchases
        /// </summary>
        public List<InfoAboutPurchase> Purchases;
        /// <summary>
        /// Date
        /// </summary>
        public DateTime Date { get; set; }
        /// <summary>
        /// Creates an instance of the DayInfo class
        /// </summary>
        /// <param name="date">date</param>
        /// <param name="purchases">purchases</param>
        public DayInfo(DateTime date, List<InfoAboutPurchase> purchases)
        {
            Date = date;
            Purchases = purchases;
        }

        /// <summary>
        /// Method of getting quantity fishing tackle
        /// </summary>
        /// <param name="type">Type of fishing</param>
        /// <returns>quantity</returns>
        private static int GetNumber(List<DayInfo> periodDays, FishingThings type)
        {

            int number = 0;
            foreach (var day in periodDays)
            {
                foreach (var purchase in day.Purchases)
                {
                    if (purchase.ThingType == type)
                        number++;
                }
            }
            return number;
        }

        public static string GetPopularTackle(List<DayInfo> periodDays)
        {
            int FishingRodCount = GetNumber(periodDays, FishingThings.FishingRod);
            int SpinningCount = GetNumber(periodDays, FishingThings.Spinning);
            int PickerCount = GetNumber(periodDays, FishingThings.Picker);
            int FiderCount = GetNumber(periodDays, FishingThings.Fider);
            Dictionary<FishingThings, int> purchases = new Dictionary<FishingThings, int>(4);
            purchases.Add(FishingThings.FishingRod, FishingRodCount);
            purchases.Add(FishingThings.Spinning, SpinningCount);
            purchases.Add(FishingThings.Picker, PickerCount);
            purchases.Add(FishingThings.Fider, FiderCount);
            var maxValue = purchases.Max(i => i.Value);
            List<FishingThings> maxKeys = purchases.Where(i => i.Value == maxValue).Select(i => i.Key).ToList();
            string result;
            if (maxKeys.Count != 1)
            {
                result = "Not data";
            }
            else
            {
                result = maxKeys[0].ToString();
            }
            return result;
        }
        /// <summary>
        /// Add purchase
        /// </summary>
        /// <param name="days">Days</param>
        /// <param name="purchase">Purchase</param>
        public static void AddThings(List<DayInfo> days, InfoAboutPurchase purchase)
        {
            bool dayExistense = false;
            foreach (var day in days)
            {
                if (day.Date.Date == purchase.Date.Date)
                {
                    day.Purchases.Add(purchase);
                    dayExistense = true;
                }
            }
            if (!dayExistense)
                days.Add(new DayInfo(purchase.Date, new List<InfoAboutPurchase>() { purchase }));
        }
        /// <summary>
        /// Quantity
        /// </summary>
        /// <param name="days">Days</param>
        /// <param name="type">Type of fishing</param>
        /// <returns>Quantity</returns>
        public static double GetQuantityty(List<DayInfo> days, FishingType type)
        {
            double typeNumber = 0;
            foreach (var day in days)
            {
                foreach (var purchase in day.Purchases)
                {
                    if (purchase.FishingType == type)
                        typeNumber++;
                }
            }
            return typeNumber;
        }

        /// <summary>
        /// Calc average
        /// </summary>
        /// <param name="days">Days</param>
        /// <returns>average</returns>

        public static double GetAverage(List<DayInfo> days)
        {
            double sum = 0;
            int countPrice = 0;
            foreach (var day in days)
            {
                foreach (var pur in day.Purchases)
                {
                    sum += pur.Price;
                    countPrice++;
                }

            }
            double average = sum / countPrice;

            return average;

        }
    }
}
