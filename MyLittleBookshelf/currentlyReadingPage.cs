using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyLittleBookshelf
{
    public partial class currentlyReadingPage : UserControl
    {
        public currentlyReadingPage()
        {
            InitializeComponent();

            //Current year's info at currently reading page
            DateTime now = DateTime.Now;
            DateTime end = new DateTime(now.Year + 1, 1, 1);
            int daysLeftInYear = (int)(end - now).TotalDays;
            string daysLeftInYearString = daysLeftInYear.ToString();

            DaysLeftLabel.Text = daysLeftInYearString;
            //
        }
    }
}
