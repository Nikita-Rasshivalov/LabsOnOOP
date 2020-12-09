using System;
using System.Collections.Generic;
using System.Text;

namespace Production
{
 
    /// <summary>
    /// Class Fruits
    /// </summary>
    public class Fruits : InfoAboutProduction
    {

        /// <summary>
        /// Product type
        /// </summary>
        private ProdTypes type = ProdTypes.Fruits;
        /// <summary>
        /// Redefinit propertie ProdTypes
        /// </summary>
        public override ProdTypes Type { get { return type; } }
        /// <summary>
        /// Create  an instance of the fruits
        /// </summary>
        /// <param name="firstPrice">firstPrice</param>
        /// <param name="kind">kind</param>
        /// <param name="technology">technology</param>
        public Fruits(double firstPrice, string kind, bool technology) : base(firstPrice, kind, technology)
        {

        }
    }
}
