﻿using System;
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

            //Current year's info at Home page 
            DateTime now = DateTime.Now;
            DateTime end = new DateTime(now.Year + 1, 1, 1);
            int daysLeftInYear = (int)(end - now).TotalDays;
            string daysLeftInYearString = daysLeftInYear.ToString();

            DaysLeftLabel.Text = daysLeftInYearString;
            //
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Goodreads acar
            Process.Start("https://www.goodreads.com/user/show/14823687-tutku");
        }
    }
}
