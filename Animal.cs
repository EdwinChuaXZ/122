//written by Edwin
//2/27
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Animals_and_Sounds
{
    public class Animal
    {
        //property
        private string name = "n/a";
        // get and set
        public string Name { get { return this.name; } set { this.name = value; } }

        //constructor 
        public Animal(string aname)
        {

            this.Name = aname;


        }

        //virtual method  Method
        public virtual string MakeSound() {

            return "Some generic animal sound";
        
        
        }
        //override
        public override string ToString()
        {
            string message = "";

            message += "Name  :" + Name +"Sound"+ MakeSound() + "\n";

            return message;


        }
    }
}
