// written by Edwin
// 2/6/2025
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Watchtower
{
    public class Watchtower
    {
        private double x = -1.00; // user input variable
        private double y = -1.00; 

        //get and set
        public double X { get { return this.x; } set { this.x = value; } }

        public double Y { get { return this.y; } set { this.y = value; } }

        public string CCoordinates()//Determine coordinates
        {
            string ccoordinates = "n/a";

            if(x<0 && y>0) { ccoordinates = "NW"; }
            else if(x<0 && y==0) { ccoordinates = "W"; }
            else if (x < 0 && y < 0) { ccoordinates = "SW"; }
            else if (x == 0 && y > 0) { ccoordinates = "N"; }
            else if (x == 0 && y == 0) { ccoordinates = "!"; }
            else if (x == 0 && y < 0) { ccoordinates = "S"; }
            else if (x > 0 && y > 0) { ccoordinates = "NE"; }
            else if (x > 0 && y == 0) { ccoordinates = "E"; }
            else if (x > 0 && y < 0) { ccoordinates = "SE"; }

            return ccoordinates;


        }

        public override string ToString()//override
        {

            string message = "";

            if (CCoordinates() == "!") { message += "The enemy is here !"+"\n"; }
            else{ message += "The enemy is to the " + CCoordinates() + " !\n"; }

            return message;
        }
    }
}
