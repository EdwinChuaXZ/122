//written by Edwin
//2/26

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles_and_Cars
{
    public class Motorcycle : Vehicle
    {
        //o	Properties 
        private bool hSidecar = true;

        //get and set
        public bool HSidecar { get { return this.hSidecar; } set { this.hSidecar = value; } }

        //constructor 

        public Motorcycle(string make, string model, int year, bool hSidecar) : base(make, model, year)
        {

            this.HSidecar = hSidecar;

        }

        //override
        public override string ToString()
        {

            string message = "";

            message += base.ToString() + " " + "Has Sider Car? "+HSidecar.ToString() + " ";

            return message;

        }
    }
}
