using Peoples;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InfoAboutHumans
{
    /// <summary>
    /// Class TeacherInformationForm
    /// </summary>
    public partial class TeacherInformationForm : Form
    {
        /// <summary>
        /// TeacherInformationForm 
        /// </summary>
        /// <param name="humans"></param>
        public TeacherInformationForm(List<Human> humans)
        {
            InitializeComponent();
            GetTeacherLoad(humans);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
        /// <summary>
        /// Teacher loads
        /// </summary>
        /// <param name="humans">humans</param>
        public void GetTeacherLoad(List<Human> humans)
        {
            humans = Reader.GetHuman();
            var teachersList = new List<Teacher>();
            string info = "";
            string birth = ("years");
            foreach (var hum in humans)
            {
                if (hum.Status == StatusOfHuman.Teacher && (DateTime.Now.Year - hum.birth)>40)
                {
                    teachersList.Add((Teacher)hum);
                    info += hum.secondName+ " " + hum.YearsOld + " " + birth + " " + hum.ConvertToString(hum.load) + '\n';
                 

                }
            }
            var maxOne = Teacher.MaxLoad(teachersList, "OOP");
            Infolabel1.Text = maxOne.ToString();
            var maxTwo = Teacher.MaxLoad(teachersList, "Math");
            Infolabel2.Text = maxTwo.ToString();
            var maxThree = Teacher.MaxLoad(teachersList, "Physics");
            Infolabel3.Text = maxThree.ToString();
            labelInfo.Text  = info;
           
        }

     
    }
}
