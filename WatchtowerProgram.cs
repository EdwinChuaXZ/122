// Written by Edwin
// 2/6/2025
using System.Diagnostics.Metrics;

namespace Watchtower
{
    internal class WatchtowerProgram
    {
        public static void Main(string[] args)
        {
            WatchtowerClass aWatchtowerClass = new WatchtowerClass();

            // input x and y variable

            Console.WriteLine("Pls enter the coordinates: ");
            Console.WriteLine("X values: ");
            aWatchtowerClass.GetX = Convert.ToInt32(Console.ReadLine());
           
            Console.WriteLine("Y values: ");
            aWatchtowerClass.GetY = Convert.ToInt32(Console.ReadLine());

            //output result
            Console.WriteLine(aWatchtowerClass.ToString());

        }
    }
}
