using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLittleBookshelf
{
    class Kitap
    {
        private string bookName;
        private string authorName;
        private int pageNumber;
        private int yourRating;
        private double goodreadsRating;
        private DateTime readDate;

        //addNewBook daki price ekleme kısmı
        private double koboPrice;
        private double shelfPrice;
        private double wantToBuyPrice;
        private int order;
        //

        //checkBox lar bool oldu
        private bool readOrNot;
        private bool favorite;
        private bool wantToRead;
        private bool currentlyReading;
        private bool seriesOrNot;
        private bool kobo;
        private bool shelf;
        private bool wantToBuy;
        //

        public Kitap ()
        {

        }


        public Kitap (string bookName, string authorName, int pageNumber, int yourRating, double goodreadsRating,
                      DateTime readDate, double koboPrice, double shelfPrice, double wantToBuyPrice, int order,
                      bool readOrNot, bool favorite, bool wantToRead, bool currentlyReading, bool seriesOrNot, bool kobo,
                      bool shelf, bool wantToBuy)
        {
            this.bookName = bookName;
            this.authorName = authorName;
            this.pageNumber = pageNumber;
            this.yourRating = yourRating;
            this.goodreadsRating = goodreadsRating;
            this.readDate = readDate;
            this.koboPrice = koboPrice;
            this.shelfPrice = shelfPrice;
            this.wantToBuyPrice = wantToBuyPrice;
            this.order = order;
            this.readOrNot = readOrNot;
            this.favorite = favorite;
            this.wantToRead = wantToRead;
            this.order = order;
            this.readOrNot = readOrNot;
            this.favorite = favorite;
            this.wantToRead = wantToRead;
            this.currentlyReading = currentlyReading;
            this.seriesOrNot = seriesOrNot;
            this.kobo = kobo;
            this.shelf = shelf;
            this.wantToBuy = wantToBuy;

        }
        public void toString ()
        {
            Console.WriteLine("page:" + pageNumber);
        }

    }
}
