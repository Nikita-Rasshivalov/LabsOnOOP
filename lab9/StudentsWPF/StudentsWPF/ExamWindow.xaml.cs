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
    /// Class ExamWindow
    /// </summary>
    public partial class ExamWindow : Window
    {
        /// <summary>
        /// List names of exams
        /// </summary>
        public List<Exam> Names { get; set; }
        /// <summary>
        /// Create ExamWindow
        /// </summary>
        /// <param name="Names"></param>
        public ExamWindow(List<Exam> Names)
        {
            InitializeComponent();
            this.Names = Names;

        }
        /// <summary>
        /// Add exam button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int count = GetCount();
           
            try
            {
                if (count == 0)
                {
                    throw new NoValuesExeption("Count of exam can't be zero");
                }
                MainWindow.Flag = true;
                if (MainWindow.Flag == true)
                {
                    for (int i = 0; i < count; i++)
                    {
                        ExamNamesWindow name = new ExamNamesWindow(Names);
                        name.ShowDialog();
                    }
                }

                
            }
            catch (NoValuesExeption)
            {
                MessageBox.Show("Count of exam is zero!");
            }
            Close();


        }
        /// <summary>
        /// Get count
        /// </summary>
        /// <returns>count of exam</returns>
        public int GetCount()
        {
            int CountExam;
            int.TryParse(NumExam.Text, out CountExam);
            MainWindow.NumOfExams = CountExam;
            return CountExam;
        }
        /// <summary>
        /// Check  on enter int num 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NumExam_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !(Char.IsDigit(e.Text, 0));
        }
    }
}
