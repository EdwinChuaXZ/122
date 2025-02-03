//Witten by Edwin
//2/1/2025

using System.ComponentModel;
using System.Runtime.Intrinsics.Arm;

namespace TheFourSistersandtheDuckbear
{
    public class Program
    {
        static void Main(string[] args)
        {
            Count aCount = new Count();
            while (true)
            {
                Console.WriteLine("The number of eldest sisters:");
                int asister1 = Convert.ToInt32(Console.ReadLine()); //Write the amount each of the four sisters owns
                if (asister1 >= 0) { aCount.Sister1 = asister1; } //if the number is correct
                else { Console.WriteLine("Please enter the correct number." + "\n" + "\n"); continue; }//If the number is less than 0, display an error and run again

                Console.WriteLine("The number of second sisters:");
                int asister2 = Convert.ToInt32(Console.ReadLine());//Write the amount each of the four sisters owns
                if (asister2 >= 0) { aCount.Sister2 = asister2; } //if the number is correct
                else { Console.WriteLine("Please enter the correct number." + "\n" + "\n"); continue; }//If the number is less than 0, display an error and run again

                Console.WriteLine("The number of third sisters:");
                int asister3 = Convert.ToInt32(Console.ReadLine());//Write the amount each of the four sisters owns
                if (asister3 >= 0) { aCount.Sister3 = asister3; } //if the number is correct
                else { Console.WriteLine("Please enter the correct number." + "\n" + "\n"); continue; }//If the number is less than 0, display an error and run again

                Console.WriteLine("The number of fourth sisters:");
                int asister4 = Convert.ToInt32(Console.ReadLine());//Write the amount each of the four sisters owns
                if (asister4 >= 0) { aCount.Sister4 = asister4; } //if the number is correct
                else { Console.WriteLine("Please enter the correct number." + "\n" + "\n"); continue; }//If the number is less than 0, display an error and run again

                Console.WriteLine(aCount.ToString());

                Console.WriteLine("Do you want to continue? (Y or N) " + "\n" + "\n");//Whether to continue running.
                string? choose = Console.ReadLine();

                if (choose == "Y" || choose == "y") { continue; }//If so, run again

                else if (choose == "N" || choose == "n") { Console.WriteLine("End of program"); break; }//If not, stop

                else { Console.WriteLine("Input error, end of program"); break; }//Input error, stop

            }
        }
    }
}
