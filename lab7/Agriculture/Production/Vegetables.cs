using System;
using System.Collections.Generic;
using System.Text;

namespace Production
{


    public class Vegetables : InfoAboutProduction
    {
        /// <summary>
        /// Product type
        /// </summary>
        private ProdTypes type = ProdTypes.Vegetables;
        /// <summary>
        /// Redefinit propertie ProdTypes
        /// </summary>
        public override ProdTypes Type { get { return type; } }
        /// <summary>
        /// Create  an instance of the vegetables
        /// </summary>
        /// <param name="firstPrice">firstPrice</param>
        /// <param name="kind">kind</param>
        /// <param name="technology">technology</param>
        public Vegetables(double firstPrice, string kind, bool technology) : base(firstPrice, kind, technology)
        {

        }

     
    }
}
