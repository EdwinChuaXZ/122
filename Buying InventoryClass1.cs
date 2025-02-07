//Written by Edwin
//2/6/2025
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buying_Inventory
{
    public class CMENU
    {
        private int userinput = -1;

        //get and set
        public int Userinput
        {

            get { return this.userinput; }
            set { this.userinput = value; }
        }

        //override
        public override string ToString()
        {
            string message = "";

            switch (userinput)//switch function
            {

                case 1: message += "Rope cost 10 gold.";
                    break;
                case 2:
                    message += "Torches cost 15 gold.";
                    break;
                case 3:
                    message += "Climbing Equipment cost 25 gold.";
                    break;
                case 4:
                    message += "Clean Water cost 1 gold.";
                    break;
                case 5:
                    message += "Machete cost 20 gold.";
                    break;
                case 6:
                    message += "Canoe cost 200 gold.";
                    break;
                case 7:
                    message += "Food Supplies cost 1 gold.";

                    break;
                    
            }
            return message;
        }
    }
}
