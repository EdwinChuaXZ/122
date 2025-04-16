using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//written by Edwin
//4/9
namespace Merge_Strings_Alternately
{
    internal class MergeStringClass1
    {
        public string MergeAlternately(string word1, string word2)
        {
            //is the current index
            int x = 0;

            //a & b are the length number of word we get
            int a = word1.Length;
            int b = word2.Length;

            // return sentence we need
            string sentence = "";

            //x must need to greater than a or b, it is mean still have letter need to check
            while (x < a || x <= b)
            {
                //Run two if function and save them alternatel
                if (x < a) { sentence += word1[x]; }
                if (x < b) { sentence += word2[x]; }

                // next index
                x++;

            }
            // return the combine sentence
            return sentence;
        }
    }
}
