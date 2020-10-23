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

        public StudentMark(Exam Exam, int Mark)
        {
            this.Exam = Exam;
            this.Mark = Mark;
        }

        public StudentMark()
        {

        }
        public Exam Exam;
        public int Mark;
    }
}
