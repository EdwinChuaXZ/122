//written by Edwin
//4/9
namespace Robot_Return_to_Origin
{
    internal class RobotProgram
    {
        static void Main(string[] args)
        {
            RobotClass1 aRobotClass1 = new RobotClass1();

            string moves = "L";

            bool ans = aRobotClass1.JudgeCircle(moves);

            Console.WriteLine(ans);
        }
    }
}
