//written by Edwin
//4/9
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find_the_Difference
{
    internal class FindDiffClass1
    {
        public char FindTheDifference(string s, string t)
        {
            //Convert text to ASCII, so use int
            int result = 0;

            //Run two foreach alternately after the conditions are met
            //ASCII 
            foreach (char c in t) { result += c; }
            foreach (char c in s) { result -= c; }

            //ASCII  change to letter
            return (char)result;
        }
    }
}
