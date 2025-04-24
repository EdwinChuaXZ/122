//Written by Edwin
//4/15
namespace Valid_Parentheses
{
    internal class VaildProgram
    {
        static void Main(string[] args)
        {
            VaildClass1 aVaildClass1 =new VaildClass1();

            string s = "{,(,),},}";

            bool ans = aVaildClass1.isValue(s);

            Console.WriteLine(ans);
        }
    }
}
