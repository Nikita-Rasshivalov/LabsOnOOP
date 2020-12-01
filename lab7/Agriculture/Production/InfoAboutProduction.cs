using System;
using System.Collections.Generic;
using System.Text;

namespace Production
{
  
    public abstract class InfoAboutProduction
    {
        List<InfoAboutProduction> Productins = new List<InfoAboutProduction>();
        public int PriceOnKillo { get; set; }
        public bool Technology { get; set; }
        public abstract string[] Types { get; }

    }
}
