//Written by Edwin
//2/2/2025
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repairing_the_Clocktower
{
    public class Count
    {
        private int hour = -1;

        //get and set
        public int Hour { get { return this.hour; }set { this.hour = value; } }

        //Determine whether it is an even number or an odd number
        public double Remainder()
        {
            double remainder = -1.00;

            remainder = this.hour % 2.00;

            return remainder;
        }
        public override string ToString()//override
        {
            String message = "";

            message += "Time entered : " + this.hour + "\n";

            //Judgment of odd and even numbers
            if (Remainder() == 0) { message += "Tick "+ "\n"; }
            else { message += "Tock " + "\n"; }

            return message;
        }
    }
}
