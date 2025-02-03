//Written by Edwin
//2/2/2025
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Dominion_of_Kings
{
    public class Count
    {
        private int provine = -1;
        private int duchy = -1;
        private int estate = -1;

        // get and set
        public int Provine {  get { return this.provine; } set { this.provine = value*6;} }

        public int Duchy { get { return this.duchy; } set { this.duchy = value*3; } }

        public int Estate { get { return this.estate; } set { this.estate = value*1; } }

        public int Ctotal() {//The total is:

            int ctotal = -1;

            ctotal = this.provine + this.duchy + this.estate;

            return ctotal;
        
        
        }
        public override string ToString()//override
        {
            String message = "";

            message += "The provine of the kingdom is : " + this.Provine + "\n";
            message += "The duchy of the kingdom is : " + this.Duchy + "\n";
            message += "The estate of the kingdom is : " + this.Estate + "\n";
            message += "The point is: " + this.Ctotal() + "\n";

            return message;
        }

    }
}
