using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peoples
{
    /// <summary>
    /// Class bom
    /// </summary>
    public class Bom:Human
    {
        /// <summary>
        /// Create bom
        /// </summary>
        /// <param name="secondName"> second Name </param>
        /// <param name="status">status</param>
        /// <param name="birth">birthparam>
        public Bom(string secondName, StatusOfHuman status, int birth,int[] load) : base(secondName, status, birth, load)
        {

        }
        /// <summary>
        /// Override  Svedenija
        /// </summary>
        /// <returns>Year load</returns>
        public override double Svedenija()
        {
            double bottles = 0;
            for (int i = 0; i < load.Length; i++)
            {
                bottles = bottles + load[i];
            }
            return bottles;
        }
        /// <summary>
        /// Override method GetInfo
        /// </summary>
        /// <returns>info</returns>
        public override string GetInfo()
        {
            double bottles = Svedenija();

            string info = $"{secondName} {status} {birth} {bottles}";
            return info;
        }
    }
}
