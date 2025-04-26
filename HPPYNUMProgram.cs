//written by Edwin
//4/24
namespace Happy_Number
{
    internal class HPPYNUMProgram
    {
        static void Main(string[] args)
        {
            HPPYNUMClass1 aHPPYNUMClass1 = new HPPYNUMClass1();

            int n = 19;

            bool ans = aHPPYNUMClass1.IsHappy(n);   

            Console.WriteLine(ans);
        }
    }
}
