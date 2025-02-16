using System;
using System.Collections.Generic;
using System.Linq;
// Written by Edwin
//2/10/2025
using System.Text;
using System.Threading.Tasks;

namespace Multiply
{
    public class MultiplyClass
    {
        public List <int> FindMul(List<int>aList) {

            
            // set mul = new array
            List<int> Mul = new List<int>();
            //num is the length of array
            int Num = aList.Count;
            //run all array and Mul all number
            foreach(int i in aList) {  Mul.Add(i * Num); }


            return Mul;
        }
    }
}
