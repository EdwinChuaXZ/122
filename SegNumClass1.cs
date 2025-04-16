//written by Edwin
//4/9
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_of_Segments_in_a_String
{
    internal class SegNumClass1
    {
        public int CountSegments(string s) {

            //save the before letter
            char preleeter = ' ';
            // count letter
            int count = 0;

            //check all letter
            foreach (char c in s) {

                //If the letter is not empty and the previous letter is empty
                ////then it is considered a word
                if (c != ' ' && preleeter == ' ')
                {
                    //count the word +1
                    count++;


                }


                //save the pre letter to preletter
                preleeter = c;

            }

            // return the corret number of letter
            return count;






        }
    }
}
