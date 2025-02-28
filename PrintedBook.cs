//written by Edwin
//2/26

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_System
{
    public class PrintedBook :Book
    {
        //property

        private int pageCount = -1;

        //get and set
        public int PageCount { get { return this.pageCount; } set { this.pageCount = value; } }

        //constructor 
        public PrintedBook(string title, string author, int yearPublished, int pageCount) : base(title, author, yearPublished)
        {

            this.PageCount = pageCount;

        }
        //override
        public override string ToString()
        {

            string message = "";

            message += base.ToString() + " PageCount " + this.pageCount;

            return message;

        }
    }
}
