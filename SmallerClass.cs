//Written by Edwin
//2/10/25
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Returns_smaller_number
{
    internal class SmallerClass
    {
        public string FindSmaller(List<int> aList) {
            //set first num = min
            int min = aList[0];
            // run all num, and i small then the length
            for (int i = 1; i < aList.Count; i++) {

                if (aList[i] < min) { min = aList[i]; }

            }
            //return string
            return min.ToString();
        
        
        }
    }
}
