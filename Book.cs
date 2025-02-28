//written by Edwin
//2/26

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_System
{
    public class Book
    {
        //property
        private string title = "n/a";
        private string author = "n/a";
        private int yearPublished = -1;
        //get and set
        public string Title { get { return this.title; } set { this.title = value; } }
        public string Author { get { return this.author; } set { this.author = value; } }
        public int YearPublished { get { return this.yearPublished; } set { this.yearPublished = value; } }
        //constructor
        public Book(string atitle, string aauthor, int ayearPublished)
        {
            this.Title = atitle;
            this.Author = aauthor;
            this.YearPublished = ayearPublished;
        }
        //override
        public override string ToString()
        {

            string message = "";

            message += "Title "+ Title + "Author "+ Author + " YearPublished" + YearPublished+"\n";

            return message;

        }


    }
}
