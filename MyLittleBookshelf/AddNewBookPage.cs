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
    public partial class AddNewBookPage : UserControl
    {
        private int myRating;
        public AddNewBookPage()
        {
            InitializeComponent();
            //Current year's info at AddNewBook page 
            DateTime now = DateTime.Now;
            booksAddedDate.Text = now.ToString();
            //
        }

        private void BunifuCheckbox1_OnChange(object sender, EventArgs e)
        {
            //seri ise bilgi girme paneli acilir
            givingSeriesInfoPanel.Visible = true;
        }

        private void BunifuCheckbox2_OnChange(object sender, EventArgs e)
        {
            //seri degilse gizle
            givingSeriesInfoPanel.Visible = false; 
        }

        //readYes
        private void BunifuCheckbox4_OnChange(object sender, EventArgs e) 
        {
            //readYes -> rating entry goes visible
            yourRatingPanel.Visible = !yourRatingPanel.Visible;
            //readYes -> read date goes visible
            readDatePanel.Visible = !readDatePanel.Visible;
            //readNo ya artik basamazsın
            ReadNoCheckBox.Enabled = !ReadNoCheckBox.Enabled;
        }
        
        private void BunifuCheckbox7_OnChange(object sender, EventArgs e)
        {
            //readNo -> rating entry goes invisible
            yourRatingPanel.Visible = false;
            //readNo -> read date goes invisible
            readDatePanel.Visible = false;
            //readYes e artik basamazsın
            readYesCheckBox.Enabled = !readYesCheckBox.Enabled;
            
        }

        private void AddNewBookButton_Click(object sender, EventArgs e)
        {
            //read checkbox check ise readOrNot True else false
            bool readOrNot = readYesCheckBox.Checked ? true : false;
            //series ise seriesOrNot true
            bool seriesOrNot = seriesYesCheckBox.Checked ? true : false;

            Kitap yeniKitap = new Kitap(kitapAdiTextBox.Text, authorNameTextBox.Text, Convert.ToInt32(pageNumberTextBox.Text),
                            myRating, Convert.ToDouble(goodreadsRatingTextBox.Text),readDate.Value, Convert.ToDouble(koboPriceTextBox.Text),
                            Convert.ToDouble(shelfPriceTextBox.Text), Convert.ToDouble(wantToBuyTextBox.Text), Convert.ToInt32(seriesOrderTextBox.Text),
                            readOrNot, favoriteCheckBox.Checked, wantToReadCheckBox.Checked, currentlyReadingCheckBox.Checked, 
                            seriesOrNot, koboCheckBox.Checked, shelfCheckBox.Checked, wantToBuyCheckBox.Checked);

            yeniKitap.toString();
        }


        //rating entry result
        private void ZeroPtsImageButton_Click(object sender, EventArgs e)
        {
            this.myRating = 0;
        }

        private void OnePtImageButton_Click(object sender, EventArgs e)
        {
            this.myRating = 1;
        }

        private void TwoPtsImageButton_Click(object sender, EventArgs e)
        {
            this.myRating = 2;
        }

        private void ThreePtsImageButton_Click(object sender, EventArgs e)
        {
            this.myRating = 3;
        }

        private void FourPtsImageButton_Click(object sender, EventArgs e)
        {
            this.myRating = 4;
        }

        private void FivePtsImageButton_Click(object sender, EventArgs e)
        {
            this.myRating = 5;
        }
    }
}
