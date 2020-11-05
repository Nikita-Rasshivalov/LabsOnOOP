using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students
{
    /// <summary>
    /// Class of exam and mark on exam
    /// </summary>
    
    public class StudentMark
    {
        /// <summary>
        /// Mark and name of exam
        /// </summary>
        /// <param name="Exam">name exam</param>
        /// <param name="Mark">mark on exam</param>
        public StudentMark(Exam Exam, int Mark)
        {
            this.Exam = Exam;
            this.Mark = Mark;
           
        }
        /// <summary>
        /// Mark and name of exam
        /// </summary>
        public StudentMark()
        {

        }
        public Exam Exam;
        /// <summary>
        /// Mark
        /// </summary>
        public int Mark;
        


    }
}
