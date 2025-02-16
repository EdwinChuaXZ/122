//Written by Edwin
//2/10/25
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smallest_and_Biggest_Numbers
{
    public class FindNumberClass
    {
        //MIN and Max funtion
        public int[] FindMaxMin(List<int> aList) {

            //set min and max = first number ;
            int min = aList[0];
            int max = aList[0];

            //serach all num in the list
            foreach (int i in aList) {

                //if & else to find min &max
                if (i < min) { min = i; }
                else if (i > max) { max = i; }
            }

            //return array
            
            return new int[] { min, max };
        }
    }
}
