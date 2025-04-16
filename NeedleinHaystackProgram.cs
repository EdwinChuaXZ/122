// Wiritten by Edwin Chua
//4/1
namespace Needle_in_Haystack
{
    internal class NeedleinHaystackProgram
    {
        static void Main(string[] args)
        {
            NeedleinHaystack NeedleinHaystack1 = new NeedleinHaystack();


            string haystack1 = "qsadbutsad";
            string needle1 = "sad";
            int Ans = NeedleinHaystack1.StrStr(haystack1,needle1);
          

            Console.WriteLine(Ans);


        }
    }
}
