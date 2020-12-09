using System;
using System.Collections.Generic;
using System.Text;

namespace Production
{


    public class Vegetables : InfoAboutProduction
    {
        private KindTypes type = KindTypes.Vegetables;

        public override KindTypes Type { get { return type; } }
        public Vegetables(double firstPrice, string kind, bool technology) : base(firstPrice, kind, technology)
        {

        }

     
    }
}
