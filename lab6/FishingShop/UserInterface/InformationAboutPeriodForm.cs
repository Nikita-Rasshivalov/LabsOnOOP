using ShopFishing;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace UserInterface
{
    public partial class InformationAboutPeriodForm : Form
    {
        /// <summary>
        /// Creates an instance of the InformationAboutPeriodForm class
        /// </summary>
        public InformationAboutPeriodForm()
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


        /// <summary>
        /// Get period
        /// </summary>
        /// <param name="periodDays">period days</param>
        /// <returns>correct or incorrect period</returns>
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

        /// <summary>
        /// Choose button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Сhoose_Click(object sender, EventArgs e)
        {
            totalValue.Text = "";
            errorLabel.Text = "";
            List<DayInfo> periodDays = new List<DayInfo>();

            if (GetPeriodDays(periodDays))
            {

                if (periodDays.Count == 0)
                {
                    totalValue.Text = "";
                    errorLabel.Text = "Not data";
                }
                else
                {

                    if (comboBox1.Text == "Autumn")
                    {
                        double total = DayInfo.GetQuantityty(periodDays, FishingType.Autumn);
                        totalValue.Text = Math.Round(total, 1).ToString();
                    }
                    else if (comboBox1.Text == "Spring")
                    {
                        double total = DayInfo.GetQuantityty(periodDays, FishingType.Spring);
                        totalValue.Text = Math.Round(total, 1).ToString();
                    }
                    else if (comboBox1.Text == "Summer")
                    {
                        double total = DayInfo.GetQuantityty(periodDays, FishingType.Summer);
                        totalValue.Text = Math.Round(total, 1).ToString();
                    }
                    else if (comboBox1.Text == "Winter")
                    {
                        double total = DayInfo.GetQuantityty(periodDays, FishingType.Winter);
                        totalValue.Text = Math.Round(total, 1).ToString();
                    }
                    else
                    {
                        totalValue.Text = "Not information";
                    }

                }
            }
            else
            {
               
                errorLabel.Text = "Incorrect period";
            }
        }

      
    }
}

