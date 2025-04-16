//written by Edwin
//4/9
namespace Merge_Strings_Alternately
{
    internal class MergeStringProgram
    {
        static void Main(string[] args)
        {
            MergeStringClass1 aMergeStringClass1 = new MergeStringClass1();

            string word1 = "abd";
            string word2 = "pqr";

            string ans = aMergeStringClass1.MergeAlternately(word1, word2);

            Console.WriteLine(ans);
        }
    }
}
