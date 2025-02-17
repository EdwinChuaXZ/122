//Written by Edwin
//2/16
namespace Next_letter
{
    internal class Next_letter
    {
        static void Main(string[] args)
        {
            // input the sentence
            //change all letter become upper
            String letter = "n/a";
            
            Console.WriteLine("Please enter a sentence");

            letter = Console.ReadLine().ToUpper();

            //set the change letter null first
            String change = "";

            //use foreach check and get the all letter from the sentence
            foreach (char c in letter)
            {
                //if the letter don't equal z
                if (c != 'z')
                {
                    //the letter +1, so it will next to the next letter
                    char res = (char)(c + 1);
                    //show the letter and become string
                    change += res.ToString();
                }
                //if the letter equal to z, show error.
                // because don't have next z letter
                else {Console.WriteLine("The letters contain z!"); }
        }

            //output change letter
            Console.WriteLine(change);
        }
    }
}
