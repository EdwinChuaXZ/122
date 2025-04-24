//Written by Edwin
//4/15
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find_Pivot_Index
{
    internal class FindPivotClass1
    {
        public int PivotIndex(int[] nums)
        {
            // total of the nums list
            int total = 0;

            foreach (int num in nums) {


                total += num;
            
            }

            // total of the local num + all the left num
            int leftsum = 0;

            for (int i = 0; i < nums.Length; i++) { 
            
                // total of the right sum is total-leftsum- local number
                int rightsum= total-leftsum-nums[i];

                //sum of the left = right
                if(leftsum == rightsum)
                {
                    //return index
                    return i;
                }
                //if no equal
                //updated the sum of the left
                leftsum += nums[i];
            }
            //if it never get the equal return -1
            return -1;

        }
    }
}
