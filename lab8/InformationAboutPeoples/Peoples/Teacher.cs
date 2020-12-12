using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peoples
{
    /// <summary>
    /// Class teacher
    /// </summary>
    public class Teacher : Human
    {


        /// <summary>
        ///  Create  an instance of the Teacher
        /// </summary>
        /// <param name="secondName">Second name</param>
        /// <param name="status">Status</param>
        /// <param name="birth">Birth</param>
        public Teacher(string secondName, StatusOfHuman status, int birth, int[] load) : base(secondName, status, birth, load)
        {

        }
        /// <summary>
        /// Indexator
        /// </summary>
        /// <param name="nameOfDiscipline">Name of discipline</param>
        /// <returns>values of disciplineLoad </returns>
        public int this[string nameOfDiscipline]
        {
            get
            {
                switch (nameOfDiscipline)
                {
                    case "Math": return load[0];
                    case "Physics": return load[1];
                    case "OOP": return load[2];
                    default: return 0;
                }
            }
            set
            {
                switch (nameOfDiscipline)
                {
                    case "Math":
                        load[0] = value;
                        break;
                    case "Physics":
                        load[1] = value;
                        break;
                    case "OOP":
                        load[2] = value;
                        break;
                }
            }
        }

        /// <summary>
        /// Override  Svedenija
        /// </summary>
        /// <returns>Year load</returns>
        public override double Svedenija()
        {
            double YearLoad = 0;
            for (int i = 0; i < load.Length; i++)
            {
                YearLoad = YearLoad + load[i];
            }
            return YearLoad;
        }
        /// <summary>
        /// Override method GetInfo
        /// </summary>
        /// <returns>info</returns>
        public override string GetInfo()
        {
            double YearLoad = Svedenija();
            string info = $"{secondName} {status} {birth} {YearLoad}";
            return info;
        }
    }

}

