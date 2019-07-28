using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyLittleBookshelf
{
    public partial class Form1 : Form
    {
       public Form1()
        {
            InitializeComponent();
            SidePanel.Height = HOME.Height;
            SidePanel.Top = HOME.Top;
            // HomePage.BringToFront();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close(); //Programi kapatir.
        }

        private void HOME_Click(object sender, EventArgs e)
        {
            SidePanel.Height = HOME.Height;
            SidePanel.Top = HOME.Top;
           // HomePage.BringToFront();
        }

        private void CurrentlyReadingButton_Click(object sender, EventArgs e)
        {
            SidePanel.Height = CurrentlyReadingButton.Height;
            SidePanel.Top = CurrentlyReadingButton.Top;
            // CurrentlyReadingControl.BringToFront();
        }

        private void ReadingChallengeButton_Click(object sender, EventArgs e)
        {
            SidePanel.Height = ReadingChallengeButton.Height;
            SidePanel.Top = ReadingChallengeButton.Top;
            // ReadingChallengeControl.BringToFront();
        }

        private void AddBookButton_Click(object sender, EventArgs e)
        {
            SidePanel.Height = AddBookButton.Height;
            SidePanel.Top = AddBookButton.Top;
            // AddNewBookPage.BringToFront();
        }

        private void WantToReadButton_Click(object sender, EventArgs e)
        {
            SidePanel.Height = WantToReadButton.Height;
            SidePanel.Top = WantToReadButton.Top;
            // WantToReadPage.BringToFront();
        }

        private void FavouriteButton_Click(object sender, EventArgs e)
        {
            SidePanel.Height = FavouriteButton.Height;
            SidePanel.Top = FavouriteButton.Top;
            // FavouritePage.BringToFront();
        }

        private void ReadButton_Click(object sender, EventArgs e)
        {
            SidePanel.Height = ReadButton.Height;
            SidePanel.Top = ReadButton.Top;
            // ReadPage.BringToFront();

        }
    }
}
