// Written by Edwin
// 2/1/2025
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace TheTriangleFarmer
{
    public class Triangle
    {
        //Value to be entered
        private double tbase = -1.00;
        private double theight = -1.00;

        //get and set
        public double tBase 
        {
            get { return this.tbase; }
            set { this.tbase = value; }

        }

        public double tHeight
        {
            get { return this.theight; }
            set { this.theight = value; }

        }

        public double tArea() // Triangle calculation
        {

            double tarea = -1.00;

            tarea = (this.tBase * this.tHeight) / 2;


            return tarea;
        }

        public override string ToString()//override
        {
            String message = "";

            message += "The base of a triangle is : " + this.tBase + "\n";
            message += "The height of a triangle is : " + this.tHeight + "\n";
            message += "The area of a triangle is : " + this.tArea() + "\n";
            
            return message;
        }

    }
}
