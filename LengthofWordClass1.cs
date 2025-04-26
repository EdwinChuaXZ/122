//written by Edwin
//4/24
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Length_of_Last_Word
{
    internal class LengthofWordClass1
    {
        public int LengthOfLastWord(string s)
        {
            // total of the s(input sentence)
            int total = 0;
            //the index and we start from the last one
            int index = s.Length - 1;

            //skip the final space
            while (index >= 0 && s[index] == ' ')
            {
                //go next（left）
                index--;
            }
            //if the last index != space
            //go to the method
            //it will count the number until found space
            while (index >= 0 && s[index] != ' ')
            {

                total++;
                index--;
            }

            return total;
        }
    }
}
