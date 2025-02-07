//Written by Edwin
//2/6/2025

namespace The_Magic_Cannon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int a = 1; a <= 100; a++) { // bewteen 1-100
                if (a % 3 == 0 && a % 5 == 0) {
                    Console.ForegroundColor = ConsoleColor.Blue; // color change blue
                    Console.WriteLine(a+ "Fire and Electric");


                }
                else if (a % 3 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red; // color change red
                    Console.WriteLine(a + " Fire");
                }
                
                else if (a % 5 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow; // color change yellow
                    Console.WriteLine(a+" Electric");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.White; // color change no change
                    Console.WriteLine(a + " Normal");
                }
            }

            // reset
            Console.ResetColor();

        }
        }
    
}
