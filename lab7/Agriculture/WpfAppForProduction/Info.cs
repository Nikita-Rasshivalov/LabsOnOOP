using Production;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppForProduction
{
    public class Info
    {


        public Info(ProdTypes type, string kind, double priceOnKillo, bool technology, int number)
        {
            Type = type;
            Kind = kind;
            Number = number;
            PriceOnKillo = priceOnKillo;
            if (technology==true)
            {
                Technology = "Ecology";
            }
            else
            {
                Technology = "Not Ecology";
            }
        }

        public int Number { get; }
        public ProdTypes Type { get; set; }
        public string Kind { get; set; }
        public double PriceOnKillo { get; set; }

        public string  Technology { get; set; }
    }
}
