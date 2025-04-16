//written by Edwin
//4/9
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maximum_Number_of_Balloons
{
    internal class BalloonsClass1
    {
        public int MaxNumberOfBalloons(string text)
        {
            // each letter about text
            
            int ans = 0, b = 0, a = 0, l = 0, o = 0, n = 0, s = 0;

            //check all letter
            foreach (char ch in text)
            {
                //use +1 to save the letter number
                if (ch == 'b') { b += 1; }
                else if (ch == 'a') { a += 1; }
                else if (ch == 'l') { l += 1; }
                else if (ch == 'o') { o += 1; }
                else if (ch == 'n') { n += 1; }
                else if (ch == 's') { s += 1; }

            }
            //if the letter num is same with text
            while (b >= 1 && a >= 1 && l >= 2 && o >= 2 && n >= 1)
            {
                //ans +1, and clear all letter num
                ans += 1;
                b -= 1;
                a -= 1;
                l -= 2;
                o -= 2;
                n -= 1;
            }
            
            return ans;
        }
    }
}
