// Wiritten by Edwin Chua
//4/1
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Merge_Two_Sorted_Arrays
{
    internal class MergeTwo
    {
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            //The length is minus 1, because it starts at 0.
            int LastNum1 = m - 1;
            int LastNum2 = n - 1;

            //For loop, m+n-1 is because the total length is the length of the combination of the two starting from zero
            for (int i = m + n - 1; i >= 0; i--)
            {
                //If num1 is greater than 0 and greater than num2
                if (LastNum1 >= 0 && (LastNum2 < 0 || nums1[LastNum1] > nums2[LastNum2])

                )
                {
                    //The last number of num1 is stored in list
                    nums1[i] = nums1[LastNum1];
                    LastNum1--;
                }
                //On the contrary, the last number of num2 is stored in list
                else if(LastNum2  >=0) 
                { nums1[i] = nums2[LastNum2]; 
                    LastNum2--; }
            }
        }
    }
}
