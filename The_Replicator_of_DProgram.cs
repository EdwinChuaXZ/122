//Written by Edwin
//2/6/2025
using System.ComponentModel;

namespace The_Replicator_of_D_To
{
    internal class The_Replicator_of_DProgram
    {
        static void Main(string[] args)
        {
            int[] arrays = new int[5];// array str from 0-4
            int[] arraysOfD = new int[5];// second one

            Console.WriteLine("PLS enter 5 number :"+ "\n");

            //for function: 0,1,2,3,4 = [5]
            for (int i = 1; i <= 4; i++)
            { // loop 1-5

                Console.WriteLine(i + " Num :"); //output 1-5 num

                arrays[i] = Convert.ToInt32(Console.ReadLine());// save num to array 1-5

                arraysOfD[i] = arrays[i];

            }
            Console.Write(" The array num are: "+"\n");
            //output num
            foreach (int array in arrays)
            {

                Console.Write(" "+array+" ");

            }
            Console.Write("\n"+" The second array num are: " + "\n");// copy array to new array then output again
            foreach (int arrayOfD in arraysOfD)
            {

                Console.Write(" " + arrayOfD + " ");

            }



        }


    }
}
