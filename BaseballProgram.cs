//written by Edwin Chua
//4/15
namespace Baseball_Game
{
    internal class BaseballProgram
    {
        static void Main(string[] args)
        {
            BaseballClass1 aBaseballClass1 = new BaseballClass1();

            string[] operations = { "5", "2", "C", "D", "+" };
            int ans = aBaseballClass1.CalPoints(operations);

            Console.WriteLine(ans);
        }
    }
}
