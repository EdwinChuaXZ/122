using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Watchtower
{
    public class WatchtowerClass
    {
        //user input
        private int x = -1;
        private int y = -1;

        //get and set
        public int GetX { get { return this.x; } set { this.x = value; } }
        public int GetY { get { return this.y; } set { this.y = value; } }
        // determine Coordinates, if function
        public string Coordinates()
        {
            string coordinates = "n/a";

                if(x<0 && y>0){ coordinates = "NW"; }
                else if(x<0 && y==0){ coordinates = "W"; }
                else if (x < 0 && y < 0) { coordinates = "SW"; }
                else if (x == 0 && y > 0) { coordinates = "N"; }
                else if (x == 0 && y == 0) { coordinates = "!"; }
                else if (x == 0 && y < 0) { coordinates = "S"; }
                else if (x > 0 && y > 0) { coordinates = "NE"; }
                else if (x > 0 && y == 0) { coordinates = "E"; }
                else if (x > 0 && y < 0) { coordinates = "SE"; }

                return coordinates;}

         //override
         public override string ToString()
{

             string message = "";

              if (Coordinates() == "!") { message += "The enemy is here!"+ "\n"; }
              
              else { message += "The enemy is to the " +Coordinates() + "!"; }

               return message;



}

    }
}
