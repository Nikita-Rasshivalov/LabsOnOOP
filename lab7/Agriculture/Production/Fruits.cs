using System;
using System.Collections.Generic;
using System.Text;

namespace Production
{
 

    public class Fruits : InfoAboutProduction
    {
     

        private KindTypes type = KindTypes.Fruits;

        public override KindTypes Type { get { return type; } }

        public Fruits(double firstPrice, string kind, bool technology) : base(firstPrice, kind, technology)
        {

        }
    }
}
