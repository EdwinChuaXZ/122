// Wiritten by Edwin Chua
//4/1
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Needle_in_Haystack
{
    internal class NeedleinHaystack
    {
        public int StrStr(string haystack, string needle) {

            //Confirm the length of sentence
            int StrLength = haystack.Length - needle.Length;

            //Start the loop from i and make sure the loop length should be <= string subtraction.
            for (int i=0; i<=StrLength;i++)
            {
                //Extract the string starting from i and ending at needle length.
                string Sentence = haystack.Substring(i, needle.Length);

                //If the sentences are consistent, return i.
                if (Sentence == needle)
                {

                    return i;
                }


            }

            return -1;
        } 
    }
    
}
