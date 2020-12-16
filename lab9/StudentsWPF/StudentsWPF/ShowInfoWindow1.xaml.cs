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
        public ShowInfoWindow1(List<Exam> Names)
        {
            this.Students = Students;
            this.Names = Names;
            InitializeComponent();
            FuntcionAddTable(Names,Students);


        }
        /// <summary>
        ///Function of drawing the table
        /// </summary>
        void FuntcionAddTable(List<Exam> Names, List<Student> Students)
        {

            Student s1 = new Student("Nikita", "Parashnik", "Ivvanovich");
            StudentMark[] marks = new StudentMark[2] { new StudentMark(new Exam("OOP"), 10), new StudentMark(new Exam("OAIP"), 5) };
            s1.Marks = marks;
            showTable.Items.Add(s1);
            DataGridTextColumn textColumn = new DataGridTextColumn();
            textColumn.Header = s1.Marks[0].Exam.NameOfExam;
            textColumn.Binding = new Binding("FirstName");
            showTable.Columns.Add(textColumn);

            foreach (var stud in Students)
            {
                
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


    }
}
