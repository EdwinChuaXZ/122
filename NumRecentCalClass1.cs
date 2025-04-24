//Written by Edwin
//4/15
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_of_Recent_Calls
{
    internal class NumRecentCalClass1
    {
        //create new queue and save the value in list
        private readonly Queue<int> Time;
        public NumRecentCalClass1()
        {
            //set new
            Time = new Queue<int>();

        }

        public int Ping(int t)
        {
            //use t in queue(input)

            Time.Enqueue(t);

            //the value need including in the range of t-3000

            while (Time.Peek() < t - 3000)
            {
                //remove
                Time.Dequeue();
            }
            //return
            return Time.Count;

        }

    }
}
