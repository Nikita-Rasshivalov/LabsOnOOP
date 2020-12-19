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
using Students;

namespace StudentsWPF
{
    /// <summary>
    /// class SetMarksWindow
    /// </summary>
    public partial class SetMarksWindow : Window
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
        public SetMarksWindow(List<Exam> names, List<Student> students)
        {
          
            Marks = new List<int[]>();
            for (int i = 0; i < students.Count; i++)
            {
                Marks.Add(new int[names.Count]);
            }

            this.Names = names;
            this.Students = students;
            InitializeComponent();
            FillExamNames();
            InitializeComponent();
            FillTable();
        }
        /// <summary>
        /// Fill table
        /// </summary>
        private void FillExamNames()
        {
           
        }

        /// <summary>
        ///Function of drawing the table
        /// </summary>
        private void FillTable()
        {
      
            marksTable.ItemsSource = Students;

        }

        private void SendInfo_Click(object sender, RoutedEventArgs e)
        {
           /* bool isCorrect = true;
            for (var i = 0; i < Students.Count && isCorrect == true; i++)
            {
                for (var j = 0; j < Students[i].Marks.Length && isCorrect == true; j++)
                {
                    //MessageBox.Show($"{i} {j} {Students[i].Marks.Length}");
                    if (Marks[i][j] >= 1 && Marks[i][j] <= 10)
                    {
                        Students[i].Marks[j].Mark = Marks[i][j];
                    }
                    else
                    {
                        isCorrect = false;
                    }
                }
            }
            string message;
            if (isCorrect == true)
            {
                message = "Marks succesfull have been added!";
            }
            else
            {
                message = "Incorrect marks";
            }
            MessageBox.Show(message);
            this.Close();*/
        }
        /// <summary>
        /// Close window button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
