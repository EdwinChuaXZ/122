//written by Edwin
//4/9
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_Unique_Character_in_a_String
{
    internal class UniqueCharacterClass1
    {
        public int FirstUniqChar(string s)
        {
            //check each letter form the text
            foreach (var c in s)
            {
                // indexof(c) find the c first location from s
                // lastindexof(c) find the c last location from s
                // return the unique letter index, because first = last is mean only appear one time
                if (s.IndexOf(c) == s.LastIndexOf(c)) { return s.IndexOf(c); }

            }
            // if not unique return -1
            return -1;
        }

    }
}
