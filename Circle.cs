//written by Edwin
//2/26

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes_and_Areas
{
    public class Circle : Shape
    {
        //Properties 
        private int radius = -1;
        //get and set
        public int Radius { get { return this.radius; }set { this.radius = value; } }

        //constructor 
        public Circle(string color,int radius) : base(color){

            this.Radius = radius;
        }

        public override int GetArea()
        {

            //use int and double for pi
            //change to int

            return (int)Math.Round(Math.PI * Radius* Radius);

        }
        //override
        public override string ToString()
        {

            string message = "";

            message += base.ToString() + " " + "Circle " + GetArea().ToString() + " ";

            return message;

        }
    }
}
