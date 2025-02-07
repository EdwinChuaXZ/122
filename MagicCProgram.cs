//Writting by Edwin
//2/6/2025
using System;
using System.Text;

namespace The_Magic_Cannon
{
    internal class MagicCProgram
    {
        static void Main(string[] args)
        {
            
            int i = -1;


            // for function, num = 1-100
            //Console.ResetColor(); clear
            //Console.ForegroundColor.xx; change color
            for (i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0) { Console.ForegroundColor = ConsoleColor.Blue; Console.WriteLine(i + "Fire and Electric" + "\n"); }//if both=0 = Fire and Electric

                else if (i % 3 == 0) { Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine(i + "Fire" + "\n"); } // if %3=0 = Fire

                else if (i % 5 == 0) { Console.ForegroundColor = ConsoleColor.Yellow; Console.WriteLine(i + "Electric" + "\n"); }// if %5=0 = Electric

                else  { Console.ResetColor(); Console.WriteLine(i + "Normal" + "\n"); }//if both0 = Fire and Electric

            }

           
        }
    }
}
