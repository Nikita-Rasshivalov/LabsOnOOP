using System;
using System.Collections.Generic;
using System.Text;

namespace Production
{
    /// <summary>
    /// Class berries
    /// </summary>
    public class Berries : InfoAboutProduction
    {
        /// <summary>
        /// Product type
        /// </summary>
        private ProdTypes type = ProdTypes.Berries;
        /// <summary>
        /// Redefinit propertie ProdTypes
        /// </summary>
        public override ProdTypes Type { get { return type; } }
        /// <summary>
        /// Create  an instance of the berries
        /// </summary>
        /// <param name="firstPrice">firstPrice</param>
        /// <param name="kind">kind</param>
        /// <param name="technology">technology</param>
        public Berries(double firstPrice, string kind, bool technology) : base(firstPrice, kind, technology)
        {

        }


    }
}
