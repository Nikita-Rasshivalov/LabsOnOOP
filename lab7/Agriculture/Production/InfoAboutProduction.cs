using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;


namespace Production
{
    public enum KindTypes
    {
        Fruits,
        Vegetables,
        Berries
    }

    public abstract class InfoAboutProduction
    {
        public double PriceOnKillo { get { return GetPrice(); } }
        private double firstPrice;
        public bool Technology { get; set; }
        public abstract KindTypes Type { get; }

        public string kind;

        public InfoAboutProduction( double firstPrice, string kind, bool technology)
        {
            this.firstPrice = firstPrice;
            this.kind = kind;
            Technology = technology;
        }

        public List<InfoAboutProduction> productions;
        public double GetPrice()
        {
            if (Technology == true)
            {
                firstPrice = firstPrice + firstPrice * 0.25;
            }
            return firstPrice;
        }


        private static double GetAverage(List<InfoAboutProduction> productions, string kind)
        {
            double sum = 0;
            foreach (var prod in productions)
            {
                if (prod.Technology == true && prod.kind == kind)
                {
                    sum += prod.firstPrice;
                }
            }
            double average = sum / productions.Count;
            return average;
        }

    }
}
