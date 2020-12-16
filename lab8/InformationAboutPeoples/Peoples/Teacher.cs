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
        /// status
        /// </summary>
        private StatusOfHuman status = StatusOfHuman.Teacher;
        public override StatusOfHuman Status { get { return status; } }
        /// <summary>
        ///  Create  an instance of the Teacher
        /// </summary>
        /// <param name="secondName">Second name</param>
        /// <param name="birth">Birth</param>
        public Teacher(string secondName, int birth, int[] load) : base(secondName, birth, load)
        {

        }
        /// <summary>
        /// Convert to string
        /// </summary>
        /// <param name="load">load</param>
        /// <returns>loadsreturns>
        public override string ConvertToString(int[] load)
        {
            string loads = "";
            foreach (var i in load)
            {
                loads = loads + " " + i.ToString();
            }
            loads += " (Load) ";
            return loads;
        }
        /// <summary>
        /// Indexator
        /// </summary>
        /// <param name="nameOfDiscipline">nameOfDiscipline</param>
        /// <returns>values of disciplineLoad </returns>
        public override int this[string nameOfDiscipline]
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
        /// Get max load
        /// </summary>
        /// <param name="teachers">teachers</param>
        /// <param name="subject">subject</param>
        /// <returns></returns>
        public static int MaxLoad(List<Teacher> teachers, string subject)
        {
            int max = 0;
            foreach (var hum in teachers)
            {
                if (hum.Status == StatusOfHuman.Teacher && hum.YearsOld > 40)
                {
                    if (max < hum[subject])
                        max = hum[subject];
                }
               
            }
           
            return max;
        }

        /// <summary>
        /// Get More Info
        /// </summary>
        /// <param name="load">load</param>
        /// <returns></returns>
        public override int GetMoreInfo(int[] load)
        {
            throw new NotImplementedException();
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
            string info = $"{secondName} {Status} {YearsOld} | {YearLoad} {"(Load)"}";
            return info;
        }
    }
}



