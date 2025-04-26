//written by Edwin
//4/24
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Happy_Number
{
    internal class HPPYNUMClass1
    {
        public bool IsHappy(int n) { 
        //use hashset save list
        HashSet<int>nums = new HashSet<int>();

            // if num !=1, false
            while (n != 1)
            {
           

                //if the hashset's have the num
                //it is loop, so false
                if (nums.Contains(n)) { return false; }

                //add the n in the hashset, so we can know is the next sum contain in list or not?
                nums.Add(n);

                //updated the n use the method
                n = gettotal(n);
            }
            //if n =1 , we get the ans
            return true;

                
    }
        //sum method
        public int gettotal(int n)
        {
            //ssum of number we want
            int sum = 0;

            //n need to >0
            while (n > 0)
            {
                //we get the remainder
                int num = n % 10;
                //square
                sum += num * num;
                //take integer
                n /= 10;
            }
            return sum;
        }
}}
