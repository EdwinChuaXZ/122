// Wiritten by Edwin Chua
//4/1
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remove_Element_From_Array
{
    internal class Arry
    {
        public int RemoveElement(int[] nums, int val) {
            //new array length
            int k = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                //Determine whether the number in the array is val
                if (nums[i] != val)
                {
                    //Save the value at position k
                    nums[k] = nums[i];

                    //the position of the next k
                    k++;
            }
            }
        
        
        return k;
        }
    }
}
