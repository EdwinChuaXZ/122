//Written by Edwin Chua
//2/16
namespace Vowel
{
    internal class Vowel
    {
        static void Main(string[] args)
        {
            //set the sentence we need to input and the letter get from the sentence
            String sentence = "n/a";
            string letter = "n/a";

            //set the Vowel =0 first
            int Vowel = 0;
            Console.WriteLine("Please enter a sentence");
            
            // set every letter become lower
            sentence = Console.ReadLine().ToLower();

            // use for function
            //sentence [i] will check every letter from the sentence
            for (int i = 0; i < sentence.Length; i++)
            {

                //Use a, e, i, o, u respectively to make fear judgments
                //If it is vowel then++
                if (sentence[i] =='a') { Vowel++; letter = "a"; }
                if (sentence[i] == 'e') { Vowel++; letter = "e"; }
                if (sentence[i] == 'i') { Vowel++; letter = "i"; }
                if (sentence[i] == 'o') { Vowel++; letter = "o"; }
                if (sentence[i] == 'u') { Vowel++; letter = "u"; }
                // if the letter isn't vowel, dont do any thing
                else { letter = " "; }
            }

            //output vowel number
            Console.WriteLine(Vowel);
        }
    }
}
