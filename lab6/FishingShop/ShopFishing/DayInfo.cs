using System;
using System.Collections.Generic;

namespace ShopFishing
{
    public enum FishingThings
    {
        FishingRod,
        Spinning,
        Fider,
        Picker
    }

    public enum FishingType
    {
        Summer,
        Winter
    }


    public class DayInfo
    {
        public class InfoAboutPurchase
        {

            public FishingType FishingType { get; set; }
            public DateTime Date { get; set; }
            public FishingThings ThingType { get; set; }

            public InfoAboutPurchase(FishingThings thingType, DateTime date)
            {
                Date = date;
                ThingType = thingType;
            }

            public InfoAboutPurchase()
            {

            }
        }

        public List<InfoAboutPurchase> Purchases;
        public DateTime Date;
        public DayInfo(DateTime date, List<InfoAboutPurchase> purchases)
        {
            this.Date = date;
            this.Purchases = purchases;
        }
        public int FishingRodNumber { get { return GetNumber(FishingThings.FishingRod); } }
        public int Spinning { get { return GetNumber(FishingThings.Spinning); } }
        public int Fider { get { return GetNumber(FishingThings.Fider); } }
        public int Picker { get { return GetNumber(FishingThings.Picker); } }

        private int GetNumber(FishingThings type)
        {
            int number = 0;
            foreach (var purchase in Purchases)
            {
                if (purchase.ThingType == type)
                    number++;
            }
            return number;
        }




    }
}
