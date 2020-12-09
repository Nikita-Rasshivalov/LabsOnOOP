using System;
using System.Collections.Generic;
using System.Text;

namespace Production
{
    public class Berries : InfoAboutProduction
    {
        private KindTypes type = KindTypes.Berries;
        public override KindTypes Type { get { return type; } }

        public Berries(double firstPrice, string kind, bool technology) : base(firstPrice, kind, technology)
        {

        }


    }
}
