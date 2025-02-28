//written by Edwin
//2/26


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles_and_Cars
{
    public class Car : Vehicle
    {
        //property

        private int numberOfDoors =-1;

        //get and set
        public int NumberOfDoors {  get { return this.numberOfDoors; } set { this.numberOfDoors = value; } }

        //constructor 
        public Car(string make, string model, int year, int numberOfDoors) : base(make, model,year) {
        
            this.NumberOfDoors = numberOfDoors;
        
        }
        //override
        public override string ToString() {

            string message = "";

            message += base.ToString() + " " + NumberOfDoors.ToString() + " doors";

            return message;
        
        }
    }
}
