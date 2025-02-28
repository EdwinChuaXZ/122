//written by Edwin
//2/26

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_System
{
    public class Ebook : Book
    {
        //property

        private int fileSizeMB = -1;

        //get and set
        public int FileSizeMB { get { return this.fileSizeMB; } set { this.fileSizeMB = value; } }

        //constructor 
        public Ebook(string title, string author, int yearPublished,int fileSizeMB) : base(title, author, yearPublished)
        {

            this.FileSizeMB = fileSizeMB;

        }
        //override
        public override string ToString()
        {

            string message = "";

            message += base.ToString() + " FileSizeMB " +this.FileSizeMB ;

            return message;

        }
    }
}
