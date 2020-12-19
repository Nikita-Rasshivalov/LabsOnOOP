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
        /// Stent
        /// </summary>
        private Student Stud { get; set; }
     
        /// <summary>
        /// Create ShowInfoWindow1
        /// </summary>
        /// <param name="names">names of student</param>
        /// <param name="students"students></param>
        public SetMarksWindow(Student stud)
        {
            this.Stud = stud;
            InitializeComponent();
            FillTable();
        }
        /// <summary>
        ///Function of drawing the table
        /// </summary>
        private void FillTable()
        {
      
            marksTable.ItemsSource = Stud.Marks;

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
