//Written by Edwin Chua
//2/16/2025

namespace Alphabetically
{
    internal class AlphabeticallyProgram
    {
        static void Main(string[] args)
        {
            //set the sentence we need input
            String letter = "n/a";
            //use the bool to detem is the sentence Alphabetically or not
            //set the Alphabetically become true first
            bool Alphabetically = true;
            
            Console.WriteLine("Please enter a sentence");

            letter = Console.ReadLine();

            // use for function
            //the function will run until the last letter
            for (int i = 1; i < letter.Length; i++)
            {
                //If the i  is greater than the following letter or num, show false result
                //letter [i-1] is the following letter
                if (letter[i]< letter[i - 1]) { Alphabetically = false; }
              
                
            }
            //if don't change anything, it is mean it is true
            Console.WriteLine(Alphabetically);
        }
    }
}
