//written by Edwin
//4/9
namespace Find_the_Difference
{
    internal class FindDiffProgram
    {
        static void Main(string[] args)
        {
            FindDiffClass1 aFindDiffClass1 = new FindDiffClass1();

            string s = "abc";
            string t = "efg";

            char ans = aFindDiffClass1.FindTheDifference(s, t);

            Console.WriteLine(ans);
        }
    }
}
