//Writting by Edwin
//2/6/2025
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discounted_Inventory
{
    internal class DiscountClass
    {
        private int choose = -1;
        private string name = "n/a";
        private double price = -1.00;
        //get and set
        public int Choose { get { return this.choose; } set { this.choose = value; } }

        public double Price { get { return this.price; } set { this.price = value; } }
        public string Name { get { return this.name; } set { this.name = value; } }
        //override and switch function
        public override string ToString()
        {
            string message = "";
            double aprice = -1;


            switch (choose)
            { // user choose menu



                case 1: aprice = 10.00; message += "Rope: "; break;
                case 2: aprice = 15.00; message += "Torches: "; break;
                case 3: aprice = 25.00; message += "Climbing Equipment: "; break;
                case 4: aprice = 1.00; message += "Clean Water : "; break;
                case 5: aprice = 20.00; message += "Machete: "; break;
                case 6: aprice = 200.00; message += "Canoe: "; break;
                case 7: aprice = 1.00; message += "Food Supplies: "; break;


            }
            if (Name == "Edwin")// determine the name
            {
                this.price = aprice * (0.50);

            }
            else { this.price = aprice; }

            message += "The price is :" + this.price + " gold.";

            return message;


        }
    } }
