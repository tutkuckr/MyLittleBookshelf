using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace MyLittleBookshelf
{
    public partial class HomePage : UserControl
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.goodreads.com/user/show/14823687-tutku");
        }

        private void DaysLeftLabel_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            DateTime end = new DateTime(now.Year + 1, 1, 1);
            int daysLeftInYear = (int)(end - now).TotalDays;
            string daysLeftInYearString = daysLeftInYear.ToString();

            DaysLeftLabel.Text = daysLeftInYearString;
        }

      
    }
}
