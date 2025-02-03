//Written by Edwin
//2/2/2025
namespace Repairing_the_Clocktower
{
    public class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Count acount = new Count();

                Console.WriteLine("Pls input the hour (12 hour system) : ");

                int ahour = Convert.ToInt32(Console.ReadLine());

                if (ahour >= 1 || ahour <= 12) { acount.Hour = ahour; }
                else { Console.WriteLine("Please enter the correct number." + "\n" + "\n"); continue; }

                Console.WriteLine(acount.ToString());

                Console.WriteLine("Do you want to continue? (Y or N) " + "\n" + "\n");//continue running?
                string? choose = Console.ReadLine();

                if (choose == "Y" || choose == "y") { continue; }//Run again

                else if (choose == "N" || choose == "n") { Console.WriteLine("End of program"); break; }//Stop

                else { Console.WriteLine("Input error, end of program"); break; }//Input error, stop
            }
        }
    }
}
