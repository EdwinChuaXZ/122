//Writting by Edwin
//2/6/2025
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace The_Prototype
{
    public class ThePrototypeClass1
    {
        private int pilot = -1;
        private int hunter = -1;

        //get and set
        public int Pilot { get { return this.pilot; } set { this.pilot = value; } }
        public int Hunter { get { return this.hunter; } set { this.hunter = value; } }

        //override
        public override string ToString()
        {
            string message = "";

            

                if (Pilot == Hunter)
                {
                    message += "You guesed the number!"; 

                }
                else if (Hunter > Pilot)
                {
                    message += Hunter + "is too high!"; 
                }
                else if (Hunter < Pilot)
                {
                    message += Hunter + "is too low!";
                }

                else { message += "Iput error"; }

               


            return message;
        }
    }
}
