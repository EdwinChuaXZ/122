//Written by Edwin
//2/6/2025
namespace The_Replicator_of_D_To
{
    public class Program
    {
        static void Main(string[] args)
        {
            // array ~range
            int[] cArry = new int[5];

            Console.WriteLine("Pls enter 5 num:");

            for (int a = 0; a < 5; a++)
            {
                Console.WriteLine("Num :");
                cArry[a] = Convert.ToInt32(Console.ReadLine());


            }

            int[] Copy = new int[5];// copy the same num

            for (int a = 0; a < 5; a++)
            {
                Copy[a] = cArry[a];


            }

            //output the array
            foreach (int acarry in cArry)
            {

                Console.Write("Array :" + acarry + "\n");

            }
            //output the copy array
            foreach (int acopy in Copy)
            {

                Console.Write("Copy array :" + acopy+"\n");

            }


        }
    }
}