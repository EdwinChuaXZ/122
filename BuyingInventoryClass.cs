//Writting by Edwin
//2/6/2025

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buying_Inventory
{
    public class BuyingInventoryClass

    {   
        private int choose = -1;
        private double price = -1.00;
        //get and set
        public int Choose { get { return this.choose; } set { this.choose = value; } }
        public double Price { get { return this.price; }  }// just read
        //override and switch function
        public override string ToString()
        {
            string message = "";

            
            switch (choose) { // user choose menu
                
                
               
              case 1 : this.price = 10;  message += "Rope: "+ this.price+" gold ";  break;
              case 2 : this.price = 15; message += "Torches: "+ this.price + " gold";  break;
              case 3 : this.price = 25; message += "Climbing Equipment: "+ this.price + " gold";  break;
              case 4 : this.price = 1; message += "Clean Water : "+ this.price + " gold";  break;
              case 5 : this.price = 20; message += "Machete: "+ this.price + "gold"; break;
              case 6 : this.price = 200; message += "Canoe: "+ this.price + " gold";  break;
              case 7 : this.price = 1;  message += "Food Supplies: "+ this.price + " gold";  break;
                    

            

        }
            return message;


        }
    }

}
            
        

    

