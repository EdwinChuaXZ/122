//Written by Edwin Chua
//2/16

namespace First_and_last
{
    internal class FirstLastcProgram
    {
        static void Main(string[] args)
        {
            String letter = "n/a";
            Console.WriteLine("Please enter a sentence");

            letter = Console.ReadLine();

            //If only one letter , show error message
            if (letter.Length <=1) { Console.WriteLine("Incompatible");  }

            //If the first letter and the last letter are the same , then show it
            //letter.length-1 is mean the last num of the sentence
            else if (letter[0] == letter[letter.Length - 1]) { Console.WriteLine("Two's a pair."); }

            //Output the first letter first use letter.length-1 show the last letter
            //then output the num 2 letter to the last second letter, use the range(1,last sencond letter)
            //and finally output show the first letter
            else { 
                Console.WriteLine(letter[letter.Length - 1]+ letter.Substring(1, letter.Length-2) + letter[0]); 
            
            }

        }
    }
}
