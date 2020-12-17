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
            FuntcionAddTable(Students);

        }
        /// <summary>
        ///Function of drawing the table
        /// </summary>
        void FuntcionAddTable(List<Student> Students)
        {
            showTable.ItemsSource = Students;
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}

