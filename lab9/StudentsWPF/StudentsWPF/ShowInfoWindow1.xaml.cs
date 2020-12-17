using Students;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Exeptions;

namespace StudentsWPF
{


    /// <summary>
    /// class ShowInfoWindow1
    /// </summary>
    public partial class ShowInfoWindow1 : Window
    {
        /// <summary>
        /// List students
        /// </summary>
        public List<Student> Students { get; set; }

        /// <summary>
        /// List names of exams
        /// </summary>

        public List<Exam> Names { get; set; }
        /// <summary>
        /// Create ShowInfoWindow1
        /// </summary>
        /// <param name="Names"></param>
        public ShowInfoWindow1(List<Exam> Names, List<Student> Students)
        {
            this.Students = Students;
            this.Names = Names;
            InitializeComponent();
            FuntcionAddTable(Names, Students);

        }
        /// <summary>
        ///Function of drawing the table
        /// </summary>
        void FuntcionAddTable(List<Exam> Names, List<Student> Students)
        {

           

            foreach (var stud in Students)
            {
                Student s = new Student(stud.FirstName,stud.SecondName,stud.ThirdName);
                showTable.Items.Add(s);
            }
            int i = 3;
            foreach (var name in Names)
            {
                Exam e = new Exam(name.NameOfExam);
                showTable.Columns[i].Header=e.NameOfExam;
                i++;
            }


        }
        /// <summary>
        /// Close this window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_ClickClose(object sender, RoutedEventArgs e)
        {

            this.Close();
        }

        private void Edit(object sender, DataGridBeginningEditEventArgs e)
        {
              e.Cancel = true;
        }
    }
}

