//written by Edwin
//2/26
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees_and_Specializations
{
    public class Manager : Employee

    {
        //properties
        private int numberOfEmployeesManaged = -1;
        
        //get and set

        public int NumberOfEmployeesManaged { get {  return this.numberOfEmployeesManaged; } set { this.numberOfEmployeesManaged = value; } }

        //constructor

        public Manager(string name, double salary, int numberOfEmployeesManaged) : base(name,salary)
        {
            this.NumberOfEmployeesManaged = numberOfEmployeesManaged;

        }

        //override
        public override string ToString()
        {

            string message = "";

            message += base.ToString()+ "NumberOfEmployeesManaged :"+ NumberOfEmployeesManaged + " \n";

            return message;
        }
    }
}
