//written by Edwin
//4/24
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_String
{
    internal class ReverseClass1
    {
        public void ReverseString(char[] s)
        {
            //the index start from begin(left)
            int leftindex = 0;
            //the index start from end(right)
            int rightindex = s.Length - 1;
            //if leftindex < rightindex, do again
            //leftindex == rightindex is mid,don't need to change
            while (leftindex < rightindex)
            {
                //swap leftindex and rightindex
                (s[leftindex], s[rightindex]) = (s[rightindex], s[leftindex]);
                //go to next index
                //leftindex+1 go right
                leftindex++;
                //rightindex-1, go left
                rightindex--;
            }



        }
    }
}
