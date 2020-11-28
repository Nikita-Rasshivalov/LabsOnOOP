using ShopFishing;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace UserInterface
{

    public partial class MoreInfForm : Form
    {
        /// <summary>
        /// Creates an instance of the MoreInformation class
        /// </summary>
        public MoreInfForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Returns to the main form by clicking the button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        bool GetPeriodDays(List<DayInfo> periodDays)
        {
            bool isCorrectPeriod;
            DateTime fromDate = fromDatePicker.Value;
            DateTime toDate = toDatePicker.Value;
            if (fromDate.Date <= toDate.Date)
            {
                DateTime currentDate = fromDate;
                while (currentDate.Date <= toDate.Date)
                {
                    DayInfo day = MainForm.Purchases.Find(x => x.Date.Date == currentDate.Date);
                    if (day != null)
                    {
                        periodDays.Add(day);
                    }

                    currentDate = currentDate.AddDays(1);
                }
                isCorrectPeriod = true;
            }
            else
            {
                isCorrectPeriod = false;
            }
            return isCorrectPeriod;
        }


        private void button1_Click(object sender, EventArgs e)
        {

            errorLabel.Text = "";
            TypeLabel.Text = "";

            List<DayInfo> periodDays = new List<DayInfo>();
            if (GetPeriodDays(periodDays))
            {

                if (periodDays.Count == 0)
                {
                    averageLabel.Text = "";
                    errorLabel.Text = "Not data";
                    TypeLabel.Text = "Not data";
                }
                else
                {
                    double average = DayInfo.GetAverage(periodDays);

                    averageLabel.Text = Math.Round(average, 1).ToString();
                    TypeLabel.Text = DayInfo.GetPopularTackle(periodDays);
                }
            }
            else
            {
                averageLabel.Text = "";
                errorLabel.Text = "Incorrect period";
            }

        }

       
    }
}

