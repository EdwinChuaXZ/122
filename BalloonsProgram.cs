//written by Edwin
//4/9

namespace Maximum_Number_of_Balloons
{
    internal class BalloonsProgram
    {
        static void Main(string[] args)
        {
            BalloonsClass1 aBalloonsClass1 = new BalloonsClass1();

            string text = "loonbalxballpoon";
           int ans= aBalloonsClass1.MaxNumberOfBalloons(text);

            Console.WriteLine(ans);
        }
    }
}
