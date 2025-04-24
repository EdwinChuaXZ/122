//Written by Edwin
//4/15
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Number_of_Students_Unable_to_Eat_Lunch
{
    internal class NumofStudentLuchClass1
    {
        public int CountStudents(int[] students, int[] sandwiches)
        {
            // save the value of student who like circular sandwiches number
            int count1 = 0;
            // save the value of student who like square  sandwiches number
            int count2 = 0;

            //check the student Flavor 
            foreach (int student in students) {
                //student who like circular sandwiches number
                if (student == 0) { count1++; }
                // student who like square  sandwiches number
                else if (student == 1) { count2++; }
                //if it have different ans return error
                else { return -1; }


            }
            //we already how many number of student's Flavor 
            //use the - to count the sandwiches can match the student number or not
            foreach (int sandwich in sandwiches)
            {
                //circular sandwiches number and -student
                //if it is 0, all student can get circular sandwiches
                if (sandwich == 0 && count1>0) { count1--; }

                //square sandwiches number and -student
                else if (sandwich == 1 && count2>0) { count2--; }


                //remaining students
                else { return count1 + count2; }

               

            }

            //If there are no remaining students
            //All students receive sandwiches
            return 0;
        } } }
