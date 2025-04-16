//written by Edwin
//4/9
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot_Return_to_Origin
{
    internal class RobotClass1
    {
        public bool JudgeCircle(string moves)
        {
            //coordinate x &y
            int x = 0, y = 0;

            // check each letter from user input
            foreach (char c in moves)
            {
                //if the letter ==, then +||- the correct coordinate
                if (c == 'L') { x++; }
                else if (c == 'R') { x--; }
                else if (c == 'U') { y++; }
                else if (c == 'D') { y--; }



            }
            //when back to the starting point, return true
            return x == 0 && y == 0;
        }
    }
}
