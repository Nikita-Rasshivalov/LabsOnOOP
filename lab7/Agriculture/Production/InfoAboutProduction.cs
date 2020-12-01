using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Text;

namespace Production
{
    enum KindTypes
    {
        Fruits,
        Vegetables,
        Berries
    }
    public abstract class InfoAboutProduction
    {
        public int PriceOnKillo { get { return GetPrice(); } }
        public bool Technology { get; set; }
        public abstract string[] Types { get; }

        public abstract int GetPrice();

  


        
        
        



    }
}
