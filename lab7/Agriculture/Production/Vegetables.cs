using System;
using System.Collections.Generic;
using System.Text;

namespace Production
{
    public class Vegetables : InfoAboutProduction
    {
        public override string[] Types { get { return types; } }
        private string[] types = { "Carrots", "Beets", "Turnips", "Cabbage", "Tomato", "Peppers", "Cucumbers", "Pumpkin", "Squash", "Spinach" };
        public Vegetables()
        {

        }

    }
}
