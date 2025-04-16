// Wiritten by Edwin Chua
//4/1

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Two_Sum
{
    internal class TWOSUMCOUNT
    {
        public int[] TwoSum(int[] nums, int target)
        {

            //First loop, use the first number.
            for (int i = 0; i < nums.Length; i++)
            {
                //The second loop uses i+1 to ensure that the next number after i is always used.
                for (int j = i + 1; j < nums.Length; j++)
                {
                    //Confirm the final condition, if the sum of the numbers is equal to target, then it is the answer.
                    if (target == nums[i] + nums[j])
                    {
                        //Returns the correct number position, not the number itself.
                        return new int[] { i, j };


                    }
                }
            }
            //Make sure there is a return.
            return new int[] { };
        }
    }

}

            
        

    

    