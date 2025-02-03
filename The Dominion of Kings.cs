//Written by Edwin
//2/2/2025
using System.Runtime.Intrinsics.Arm;

namespace The_Dominion_of_Kings
{
    public class Program
    {
        static void Main(string[] args)
        {
            

            while (true) {

                Count Melik = new Count();
                Count Casik = new Count();
                Count Balik = new Count();


                Console.WriteLine("Enter the Melik's provine of the kingdom:");
                int MProvine = Convert.ToInt32(Console.ReadLine());//the provine of the kingdom
                Console.WriteLine("Enter the Melik's duchy of the kingdom:");
                int MDuchy = Convert.ToInt32(Console.ReadLine());//the provine of the kingdom
                Console.WriteLine("Enter the Melik's estate of the kingdom:");
                int MEstate = Convert.ToInt32(Console.ReadLine());//the provine of the kingdom

                if (MProvine >= 0 || MDuchy >= 0 || MEstate >= 0) { Melik.Provine = MProvine; Melik.Duchy = MDuchy; Melik.Estate = MEstate; } //if the number is correct
                else { Console.WriteLine("Please enter the correct number." + "\n" + "\n"); continue; }//If the number is less than 0, display an error and run again

                Console.WriteLine("Enter the Casik's provine of the kingdom:");
                int CProvine = Convert.ToInt32(Console.ReadLine());//the provine of the kingdom
                Console.WriteLine("Enter the Casik's duchy of the kingdom:");
                int CDuchy = Convert.ToInt32(Console.ReadLine());//the provine of the kingdom
                Console.WriteLine("Enter the Casik's estate of the kingdom:");
                int CEstate = Convert.ToInt32(Console.ReadLine());//the provine of the kingdom

                if (CProvine >= 0 || CDuchy >= 0 || CEstate >= 0) { Casik.Provine = CProvine; Casik.Duchy = CDuchy; Casik.Estate = CEstate; } //if the number is correct
                else { Console.WriteLine("Please enter the correct number." + "\n" + "\n"); continue; }//If the number is less than 0, display an error and run again

                Console.WriteLine("Enter the Balik's provine of the kingdom:");
                int BProvine = Convert.ToInt32(Console.ReadLine());//the provine of the kingdom
                Console.WriteLine("Enter the Balik's duchy of the kingdom:");
                int BDuchy = Convert.ToInt32(Console.ReadLine());//the provine of the kingdom
                Console.WriteLine("Enter the Balik's estate of the kingdom:");
                int BEstate = Convert.ToInt32(Console.ReadLine());//the provine of the kingdom

                if (BProvine >= 0 || BDuchy >= 0 || BEstate >= 0) { Balik.Provine = BProvine; Balik.Duchy = BDuchy; Balik.Estate = BEstate; } //if the number is correct
                else { Console.WriteLine("Please enter the correct number." + "\n" + "\n"); continue; }//If the number is less than 0, display an error and run again


                Console.WriteLine("\n" + "Melik's kingdom " + "\n");
                Console.WriteLine(Melik.ToString()); //If there are no problems, the results will be displayed.
                Console.WriteLine("\n" + "Casik's kingdom " + "\n");
                Console.WriteLine(Casik.ToString());
                Console.WriteLine("\n" + "Balik's kingdom " + "\n");
                Console.WriteLine(Balik.ToString());


                int Compare = new int[] { Melik.Ctotal(), Casik.Ctotal(), Balik.Ctotal() }.Max();//Compare the largest number

                if (Compare == Melik.Ctotal()) { Console.WriteLine("\n" + "Melik is the winner :" +Melik.Ctotal()+ "\n"); }
                if (Compare == Casik.Ctotal()) { Console.WriteLine("\n" + "Casik is the winner :" + Casik.Ctotal() + "\n"); }
                if (Compare == Balik.Ctotal()) { Console.WriteLine("\n" + "Balik is the winner :" + Balik.Ctotal() + "\n"); }


                Console.WriteLine("Do you want to continue? (Y or N) " + "\n" + "\n");//continue running?
                string? choose = Console.ReadLine();

                if (choose == "Y" || choose == "y") { continue; }//Run again

                else if (choose == "N" || choose == "n") { Console.WriteLine("End of program"); break; }//Stop

                else { Console.WriteLine("Input error, end of program"); break; }//Input error, stop








            }
        }
    }
}
