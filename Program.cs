// Written by Edwin
// 2/1/2025

namespace TheTriangleFarmer
{
    internal class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Triangle aTriangle = new Triangle();




                Console.WriteLine("Enter the base of the triangle:");
                double atbase = Convert.ToDouble(Console.ReadLine());//the base of the triangle.


                if (atbase > 0) { aTriangle.tBase = atbase; } //if the number is correct
                else { Console.WriteLine("Please enter the correct number." + "\n" + "\n"); continue; }//If the number is less than 0, display an error and run again

                Console.WriteLine("Enter the height of the triangle");
                double atheight = Convert.ToDouble(Console.ReadLine());

                if (atheight > 0) { aTriangle.tHeight = atheight; }// if the number is correct
                else { Console.WriteLine("Please enter the correct number."+"\n" + "\n"); continue; }//If the number is less than 0, display an error and run again

                Console.WriteLine(aTriangle.ToString()); //If there are no problems, the results will be displayed.

                Console.WriteLine("Do you want to continue? (Y or N) " + "\n"+"\n");//Whether to continue running.
                string? choose = Console.ReadLine();

                if (choose == "Y" || choose =="y") { continue; }//If so, run again

                else if (choose == "N" || choose =="n") { Console.WriteLine("End of program"); break; }//If not, stop

                else { Console.WriteLine("Input error, end of program");break; }//Input error, stop

            }
        }
    }
}
