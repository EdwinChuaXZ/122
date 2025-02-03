using System;

namespace The_Defense_of_Consolas
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Defense of Consolas";//Window title

            while (true)
            {
                Count acount = new Count();

                Console.ForegroundColor = ConsoleColor.Blue;// out put blue color
                Console.WriteLine("Target Row?");
                int arow = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Target Column?");
                int acolumn = Convert.ToInt32(Console.ReadLine());

                //According to the coordinates of the picture, the number of points should be between 1-8, and it cannot be 0.
                //Therefore, it is wrong to judge that the input point is less than 0 and greater than 8.
                if (arow < 0 || arow >8 || acolumn < 0 || acolumn >8) {
                    Console.ForegroundColor = ConsoleColor.Red;// out put red color
                    Console.WriteLine("Please enter the correct number." + "\n" + "\n"); continue; }
                else {  acount.Xpoint=arow;  acount.Ypoint= acolumn; }

                // Other points should also be between 0-8
                if (acount.Leftpoint()<0 || acount.Rightpoint()<0 || acount.Uppoint()<0 || acount.Downpoint()<0) {
                    Console.ForegroundColor = ConsoleColor.Red;// out put red color
                    Console.WriteLine("Please enter the correct number." + "\n" + "\n"); continue; }

                else {
                    Console.ForegroundColor = ConsoleColor.White;// out put White color
                    Console.WriteLine(acount.ToString()); Console.Beep(); }//Display sound during output

                //The same function allows the user to choose whether to continue
                Console.ForegroundColor = ConsoleColor.Yellow;// out put yellow color
                Console.WriteLine("Do you want to continue? (Y or N) " + "\n" + "\n");
                string? choose = Console.ReadLine();

                if (choose == "Y" || choose == "y") { continue; }

                else if (choose == "N" || choose == "n") {
                    Console.ForegroundColor = ConsoleColor.Red;// out put red color
                    Console.WriteLine("End of program"); break; }

                else {
                    Console.ForegroundColor = ConsoleColor.Red;// out put red color
                    Console.WriteLine("Input error, end of program"); break; }

                
            }
        }
    }
}
