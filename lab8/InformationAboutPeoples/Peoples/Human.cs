using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peoples
{
    /// <summary>
    /// Enumeration of status
    /// </summary>
    public  enum StatusOfHuman
    {
        Student,
        Teacher,
        Bom
    }
    /// <summary>
    /// abstract class Human
    /// </summary>
    public abstract class Human:IComparable 
    {
        /// <summary>
        /// secondName
        /// </summary>
        public string secondName;

        /// <summary>
        /// StatusOfHuman status
        /// </summary>
        public StatusOfHuman status;
        /// <summary>
        /// birth
        /// </summary>
        public int birth;
        /// <summary>
        /// Years old
        /// </summary>
        public double YearsOld { get { return Svedenija();  }  }
        /// <summary>
        /// Lods
        /// </summary>
        public string Loads { get { return GetInfo(); } }
        /// <summary>
        /// Load
        /// </summary>
        public int[] load;

        /// <summary>
        ///  Create  an instance of the Human
        /// </summary>
        /// <param name="secondName">Second name</param>
        /// <param name="status">Status</param>
        /// <param name="birth">Birth</param>
        public Human(string secondName, StatusOfHuman status, int birth, int[] load)
        {
            this.secondName = secondName;
            this.status = status;
            this.birth = birth;
            this.load = load;
        }

        /// <summary>
        /// List human
        /// </summary>
        public List<Human> Humans = new List<Human>();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="o">Object o</param>
        /// <returns></returns>
        public int CompareTo(object o)
        {
            Human p = (Human)o;
            if (p != null)
                return this.secondName.CompareTo(p.secondName);
            else
                throw new Exception("Невозможно сравнить два объекта");
        }
        /// <summary>
        /// Convert To String
        /// </summary>
        /// <param name="load">load</param>
        /// <returns>loads</returns>
        public virtual string ConvertToString(int[] load)
        {
            string loads = "";
            foreach (var i in load)
            {
                loads = loads + " " + i.ToString();
            }
            return loads;
        }

        /// <summary>
        /// virtual method Svedenija about human birth
        /// </summary>
        /// <returns>birth</returns>
        public virtual double Svedenija()
        {
            birth = DateTime.Now. Year- birth;
            return birth;
        }

        /// <summary>
        /// Abstract Method GetInfo
        /// </summary>
        /// <returns>information</returns>
        public abstract string GetInfo();

    }
}
