//written by Edwin
//2/26
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees_and_Specializations
{
    public class Employee
    {
        //Properties 
        private string name = "n/a";
        private double salary = -1.0;


        //get and set
        public string Name {  get { return this.name; } set { this.name = value; } }
        public double Salary { get { return this.salary; } set { this.salary = value; } }

        //full contructor

        public Employee(string aname, double asalary)
        {
        
            this.Name = aname;
            this.Salary = asalary;
        }
        //override
        public override string ToString()
        {
            string message = "";

            message += "Employee: Name :" + this.Name + "Salary: " + Salary +" \n";

            return message;
        }
    }
}
