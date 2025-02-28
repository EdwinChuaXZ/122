//written by Edwin
//2/26
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Shapes_and_Areas
{
    public abstract class Shape
    {
        //proprrties
        private string color = "n/a";

        //get and set
        public string Color { get { return this.color; } set { this.color = value; } }

        //full constructor
        public Shape(string aColor) { 
        
        this.color = aColor;
        }
        //abstract
        public abstract int GetArea();

        //override
        public override string ToString()
        {
            string message = "";

            message += "Color  :" + this.Color + "\n";

            return message;


        }
    }
}
