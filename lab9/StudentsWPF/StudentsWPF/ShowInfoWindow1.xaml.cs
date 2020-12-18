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
        /// List marks
        /// </summary>
        protected List<int[]> Marks { get; set; }
        /// <summary>
        /// List names
        /// </summary>
        protected List<Exam> Names { get; set; }
        /// <summary>
        /// List students
        /// </summary>
        protected List<Student> Students { get; set; }
        /// <summary>
        /// Create ShowInfoWindow1
        /// </summary>
        /// <param name="names">names of student</param>
        /// <param name="students"students></param>
        public ShowInfoWindow1(List<Exam> names, List<Student> students)
        {

            
            for (int i = 0; i < students.Count; i++)
            {
                Marks.Add(new int[names.Count]);
            }

            this.Names = names;
            this.Students = students;
            InitializeComponent();
            FillTable();
        }
       
        /// <summary>
        ///Function of drawing the table
        /// </summary>
        private void FillTable()
        {

            marksTable.ItemsSource = Marks;
            showTable.ItemsSource = Students;
        }


        /// <summary>
        /// Open window for set marks
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SendInfo_Click(object sender, RoutedEventArgs e)
        {
            SetMarksWindow set = new SetMarksWindow(Names,Students);
            set.ShowDialog();
        }
    }
}
