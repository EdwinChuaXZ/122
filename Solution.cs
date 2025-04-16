//written by Edwin
//4/1
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort_Array_By_Parity
{
    internal class Solution
    {
        public int[] SortArrayByParity(int[] nums)
        {
            int num1 = 0;

            // for loop
            for (int i = 0; i < nums.Length; i++)
            {
                //Determine whether it is an even number
                if (nums[i] % 2 == 0)
                {
                    //The number needs to be stored in the location (temp) first, then saved to the specified location and finally put into the correct location (temp)

                    int temp = nums[num1];
                    nums[num1] = nums[i];
                    nums[i] = temp;

                    //Check next number
                    num1++;
                }

            }
            return nums;
        }
    }
}
