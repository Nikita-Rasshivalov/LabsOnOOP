using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Shapes;
using Students;

namespace StudentsWPF
{
    /// <summary>
    /// class MainWindow
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// List students
        /// </summary>
        public List<Student> Students { get; set; }
        /// <summary>
        /// Listy names of exams
        /// </summary>
        public List<Exam> Names { get; set; }

        /// <summary>
        /// Flag for enter exams and nums of exams
        /// </summary>
        public static bool Flag { get; set; }
        /// <summary>
        /// Nums of exams
        /// </summary>
        public static int NumOfExams;
        /// <summary>
        /// Create MainWindow
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
            Students = new List<Student>();
            Names = new List<Exam>();

        }
        /// <summary>
        /// AddWindow button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void Button_Add(object sender, RoutedEventArgs e)
        {
            AddWindow add = new AddWindow(Students);
            add.ShowDialog();
        }

       /// <summary>
       /// ShowWindow button
       /// </summary>
       /// <param name="sender"></param>
       /// <param name="e"></param>
        private void Button_Show(object sender, RoutedEventArgs e)
        {
            ShowInfoWindow1 add = new ShowInfoWindow1(Names,Students);
            add.ShowDialog();
        }
        /// <summary>
        /// Add exams button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void Add_Exams_Click(object sender, RoutedEventArgs e)
        {
            if (Flag == false)
            {
                ExamWindow exam = new ExamWindow(Names);

                exam.ShowDialog();
            }
            else
            {
                MessageBox.Show("Exams have been added");
            }
        }
    }
}
