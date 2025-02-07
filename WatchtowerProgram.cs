// written by Edwin
// 2/6/2025
namespace Watchtower
{
    public class Program
    {
        static void Main(string[] args)
        {
            Watchtower aWatchtower = new Watchtower();

            //input and ouput

            Console.WriteLine("Pls enter the x and y value");
            Console.WriteLine("X value:");
            double ax = Convert.ToDouble(Console.ReadLine());
             aWatchtower.X = ax ;
            Console.WriteLine("Y value:");
            double ay = Convert.ToDouble(Console.ReadLine());
            aWatchtower.Y = ay;

            Console.WriteLine(aWatchtower.ToString());
        }
    }
}
