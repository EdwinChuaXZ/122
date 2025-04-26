//written by Edwin
//4/24
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Move_Zeroes
{
    internal class MoveZeroesClass1
    {
      
            public void MoveZeroes(int[] nums)
            {
                // index of number
                //like a current location start from nums[0]
                int index = 0;
                //check all num
                for (int i = 0; i < nums.Length; i++)
                {
                    //if the num !=0
                    if (nums[i] != 0)
                    {
                        //save the current number(nums[i]) to the current location(nums[index])
                        (nums[index], nums[i]) = (nums[i], nums[index]);

                        //go to next
                        index++;
                    }
                }

            }
        }
    
}
