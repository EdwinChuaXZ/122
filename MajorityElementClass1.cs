//written by Edwin
//4/24
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Majority_Element
{
    internal class MajorityElementClass1
    {
        public int MajorityElement(int[] nums)
        {
            //array the list of num
            Array.Sort(nums);

            // count the majority, total of list'slength /2(n/2)
            int majorityNum = nums.Length / 2;
            //we start from 1
            int total = 1;

            //index start from one, because we need 1 num in left then we can compare
            //so total always has at leat 1
            for (int i = 1; i < nums.Length; i++)
            {
                //compare number
                if (nums[i] == nums[i - 1])
                {
                    //count number of length
                    total++;
                }
                //reset total
                else { total = 1; }

                //total should need > majority, then this is what we need
                if (total > majorityNum)
                {
                    return nums[i];
                }

            }
            //if not num more than majority
            return -1;
        }
    }
}
