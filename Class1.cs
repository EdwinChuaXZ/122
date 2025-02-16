// Written by Edwin
//2/10/2025

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_of_integers
{
    public class FindAbsSumClass
    {
        //Find abs sum
        public int FindABSSum(List<int> aList) {

            //set sum variable
            int sum = 0;
            //use foreach run all num
            foreach (int i in aList) {

                //Abs Sum
                sum += Math.Abs(i);

            }





            return sum;
        }
    }
}
