//Written by Edwin
//2/6/2025
namespace The_Replicator_of_D_To
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // range
            int[] originalArray = new int[5];

            // input
            Console.WriteLine("Enter 5 num:");
            for (int a = 0; a < 5; a++)
            {
                Console.Write("Enter a number: ");
                originalArray[a] = Convert.ToInt32(Console.ReadLine());
            }

            // copy array
            int[] copiedArray = new int[5];
            for (int a = 0; a < 5; a++)
            {
                copiedArray[a] = originalArray[a];
            }

            // reset
            Console.WriteLine("Original Array:");
            foreach (int num in originalArray)
            {
                Console.Write(num + " ");
            }

            Console.WriteLine("Copied Array:");
            foreach (int num in copiedArray)
            {
                Console.Write(num + " ");
            }

            Console.WriteLine("The Replicator of D'To works again!");
        }
    }
}
