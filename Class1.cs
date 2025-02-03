//Witten by Edwin
//2/1/2025
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFourSistersandtheDuckbear
{
    public class Count
    {
        private int sister1 = -1;
        private int sister2 = -1;
        private int sister3 = -1;
        private int sister4 = -1;

        // get and set
        public int Sister1
        {
            get { return this.sister1; }
            set { this.sister1 = value;}

        }
        public int Sister2
        {
            get { return this.sister2; }
            set { this.sister2 = value; }

        }
        public int Sister3
        {
            get { return this.sister3; }
            set { this.sister3 = value; }

        }
        public int Sister4
        {
            get { return this.sister4; }
            set { this.sister4 = value; }

        }
        public int Ctotal() //Total number of four sisters:
        {
            int ctotal = -1;

            ctotal = this.Sister1 + this.Sister2 + this.Sister3 + this.Sister4;
            
            return ctotal;

        }
        public int Caverage()//The four sisters received:
        {
            int ctotal = Ctotal();
            int caverage = -1;

            caverage = ctotal / 4;

            return caverage;

        }
        public int Cremainder()//Duck can get:
        {
            int ctotal = Ctotal();
            int cremainder = -1;

            cremainder = ctotal % 4;

            

            return cremainder;
        }

        public override string ToString()//override
        {
            String message = "";

            message += "The four sisters respectively own: " + "\n";
            message += "Eldest sister :"+this.Sister1 + "\n" + "Second sister :" + this.Sister2 + "\n" + "Third sister :" + this.Sister3 + "\n" + "Fourth sister :" + this.Sister4 + "\n";
            message += "There are total : " + this.Ctotal() + "\n";
            message += "Each person can get : " + this.Caverage() + "\n";
            message += "DuckBear gets : " + this.Cremainder() + "\n";

            return message;
        }



    }


}
