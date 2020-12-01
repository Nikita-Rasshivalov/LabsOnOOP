using System;
using System.Collections.Generic;
using System.Text;

namespace Production
{
    public class Berries : InfoAboutProduction
    {
        public override string[] Types { get { return types; } }
        private string[] types = { "Strawberry", "Raspberry", "Blackberry", "Bluberry", "Wildstrawberry", "Lingonberries", "Grapes", "Watermelon", "Melon", "Barberry" };
        public Berries()
        {

        }
    }
}
