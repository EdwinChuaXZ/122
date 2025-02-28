//written by Edwin
//2/26

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes_and_Areas
{
    public class Rectangle : Shape
    {
        //property
        private int width = -1;
        private int height = -1;
        //get and set
        public int Width { get { return this.width; } set { this.width = value; } }
        public int Height { get { return this.height; } set { this.height = value; } }
        //constructor 
        public Rectangle(string color, int width,int height):base (color){ 
            
            this.width = width;
            this.height = height;
        
        }

        //getarea count the Rectangle
        public override int GetArea() {
        
        return this.width * this.height;
        
        }
        //override
        public override string ToString()
        {

            string message = "";

            message += base.ToString() + "Area: "+GetArea().ToString() + " ";

            return message;

        }

    }
}
