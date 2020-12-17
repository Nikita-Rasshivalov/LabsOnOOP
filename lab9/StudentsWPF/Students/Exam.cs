using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students
{
    /// <summary>
    /// Class exam
    /// </summary>
    public class Exam
    {
        /// <summary>
        /// Create Exam
        /// </summary>
        /// <param name="nameOfExam">nameOfExam</param>

        public Exam(string nameOfExam)
        {
            this.NameOfExam = nameOfExam;
        }
        /// <summary>
        /// Class of Exam
        /// </summary>
        /// <param name="nameOfExam"></param>
        public string NameOfExam { get; set; }
    }


}
