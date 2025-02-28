//written by Edwin
//2/26
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees_and_Specializations
{
    public class Engineer:Employee
    {
        //properties
        private string specialization = "n/a";

        //get and set

        public string Specialization { get { return this.specialization; } set { this.specialization = value; } }

        //constructor

        public Engineer(string name, double salary, string specialization) : base(name, salary)
        {
            this.Specialization = specialization;

        }

        //override
        public override string ToString()
        {

            string message = "";

            message += base.ToString() + "Specialization :" + Specialization + " \n";

            return message;
        }
    }
}
