using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;


namespace Production
{
    /// <summary>
    /// Enumerator of product type
    /// </summary>
    public enum ProdTypes
    {
        Fruits,
        Vegetables,
        Berries
    }
    /// <summary>
    /// Abstract class information about production
    /// </summary>
    public abstract class InfoAboutProduction
    {
        /// <summary>
        /// Price on killogram
        /// </summary>
        public double PriceOnKillo { get { return GetPrice(); } }
        /// <summary>
        /// First price
        /// </summary>
        private double firstPrice;
        /// <summary>
        /// Technology of growing
        /// </summary>
        public bool Technology { get; set; }
        /// <summary>
        /// Product type
        /// </summary>
        public abstract ProdTypes Type { get; }


        /// <summary>
        /// Kind of plant
        /// </summary>
        public string kind;

        /// <summary>
        /// Create  an instance of the puroduct
        /// </summary>
        /// <param name="firstPrice">firstPrice</param>
        /// <param name="kind">kind</param>
        /// <param name="technology">technology</param>
        public InfoAboutProduction( double firstPrice, string kind, bool technology)
        {
            this.firstPrice = firstPrice;
            this.kind = kind;
            Technology = technology;
        }
        /// <summary>
        /// Collection of products
        /// </summary>
        public List<InfoAboutProduction> productions;
        /// <summary>
        /// Get price
        /// </summary>
        /// <returns></returns>
        public double GetPrice()
        {
            double newPrice;
            if (Technology == true)
            {
                 newPrice = firstPrice + firstPrice*0.25;
            }
            else
            {
                newPrice = firstPrice;
            }
            return newPrice;
        }

        /// <summary>
        /// Get average
        /// </summary>
        /// <param name="productions">productions</param>
        /// <param name="kind">kind</param>
        /// <returns></returns>
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
