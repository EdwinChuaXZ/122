//written by Edwin
//2/27
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals_and_Sounds
{
    public class Dog : Animal
    {
        //constructor

        public Dog(string name) : base(name)
        {

        }
        //override makesound
        public override string MakeSound()
        {
            return "Bark";
        }
    }
}
