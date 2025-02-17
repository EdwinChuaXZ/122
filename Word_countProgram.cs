//Written by Edwin
//2/16/2025
namespace Word_count
{
    internal class Word_countProgram
    {
        static void Main(string[] args)
        {
            //input the letter
            String letter = "n/a";
            Console.WriteLine("Please enter a sentence");
            //Avoid spaces at the beginning causing calculation errors
            //.trim()Can remove spaces
            letter = Console.ReadLine().Trim();


            // set the lengeth of number start from 1, at least 1 letter
            int num = 1;

            //for function, if  i small then letter length, then loop
           
            for (int i = 0; i < letter.Length; i++)
            {
                //count word by the spaces before the word
                //if the word have spaces, number plus1
                if (letter[i] == ' ' && letter[i-1] != ' ') { num += 1 ; }
                
            }

            //output the number
            Console.WriteLine(num);


        }
    }
}
