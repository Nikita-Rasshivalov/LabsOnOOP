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
    /// 
    /// </summary>
    public partial class ExamNamesWindow : Window
    {
        /// <summary>
        /// List names of exams
        /// </summary>
        public List<Exam> Names { get; set; }
        /// <summary>
        /// Create ExamNamesWindow
        /// </summary>
        /// <param name="Names"></param>
        public ExamNamesWindow(List<Exam> Names)
        {
            InitializeComponent();
            this.Names = Names;
        }

        /// <summary>
        /// Get name of exam
        /// </summary>
        /// <returns>name of exam</returns>

        public Exam GetNameOfExam()
        {
            string name = NameBox.Text;

            Exam exam = new Exam(name);
         
            return exam;
        }
        /// <summary>
        /// Add exam button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Exam name = GetNameOfExam();
            if (NameBox.Text=="")
            {
                MessageBox.Show("Enter name of exam please");
            }
            else
            {
                Names.Add(name);
                MessageBox.Show("Exam was added");
                
                Close();
            }
           
 
        }
    }
}
