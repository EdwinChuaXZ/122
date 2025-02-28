//written by Edwin
//2/26


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles_and_Cars
{
    public class Vehicle
    {
        //proprrties
        private string make = "n/a";
        private string model = "n/a";
        private int year = -1;

        //get and set

        public string Make { get { return this.make; } set { this.make = value; } }
        public string Model { get {  return this.model; } set { this.model = value; } }
        public int Year { get { return this.year; } set { this.year = value; } }

        //full constructor
        public Vehicle ( string aMake, string aModel, int aYear)
        {

            this.Make =aMake;

            this.Model =aModel;

            this.Year =aYear;

        }

        //override
        public override string ToString()
        {
            string message = "";

            message += "Year  :" + Year + "Make  :" + Make + "Model :" + Model + "\n";

            return message;


        }


    }
}
