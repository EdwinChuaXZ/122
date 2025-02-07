// written by Edwin
// 2/6/2025
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discounted_Inventory
{
    public class CMENU
    {
        private int userinput = -1;
        private string username = "n/a";
        private double price = -1.00;
        //get and set
        public int Userinput
        {

            get { return this.userinput; }
            set { this.userinput = value; }
        }
        public string Username
        {

            get { return this.username; }
            set { this.username = value; }
        }

      
        //override
        public override string ToString()
        {
            string message = "";
            double aprice=-1.00;
            
            switch (userinput)//switch function
            {
                
                case 1:
                    message += "Rope cost 10 gold.";
                    aprice = 10;
                    break;
                case 2:
                    message += "Torches cost 15 gold.";
                    aprice = 15;
                    break;
                case 3:
                    message += "Climbing Equipment cost 25 gold.";
                    aprice = 25;
                    break;
                case 4:
                    message += "Clean Water cost 1 gold.";
                    aprice = 1;
                    break;
                case 5:
                    message += "Machete cost 20 gold.";
                    aprice = 20;
                    break;
                case 6:
                    message += "Canoe cost 200 gold.";
                    aprice = 200;
                    break;
                case 7:
                    message += "Food Supplies cost 1 gold.";
                    aprice = 1;

                    break;

            }
            if (username == "Edwin") { price = aprice * 50.00 / 100.00; }//if their equals my name, 50% discount
            else { this.price = aprice ; }

            message += "The price is :" + this.price + " gold" + "\n";

            return message;
        }
    }
}
