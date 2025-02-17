//Written by Edwin
//2/14/2025
namespace Boss_Battle_Hunting_the_Manticore
{
    public class ManticoreProgram
    {
        public static void Main(string[] args)
        {

            ManticoreClass aManticoreClass = new ManticoreClass();

            while (true)
            {   
                //pilot input
                Console.WriteLine("How far away from the city do you want to station the Manticore?");
                int apilotManticore = Convert.ToInt32(Console.ReadLine());

                // input range 0-100
                if (apilotManticore < 0 || apilotManticore > 100) { Console.WriteLine("Please enter a value from 0-100."); continue; }

                
                aManticoreClass.PilotManticore = apilotManticore;
                Console.Clear();
                Console.WriteLine("It is your turn.");

                // if round <=15, continue
                while (aManticoreClass.Round <= 15 && aManticoreClass.City>0 && aManticoreClass.Manticore>0)
                {

                    
                    
                        Console.WriteLine("STATUS : Round:" + aManticoreClass.Round + "" + "  City :" + aManticoreClass.City + "/15  " + "  Manticore:" + aManticoreClass.Manticore + "/10");
                        Console.WriteLine("The cannon is expected to deal " + aManticoreClass.Expected + "damage this round.");
                        Console.WriteLine("Enter desired cannon range:");

                        int acityDefenses = Convert.ToInt32(Console.ReadLine());

                        aManticoreClass.CityDefenses = acityDefenses;


                        Console.WriteLine(aManticoreClass.ToString());
                        //every round +1
                        aManticoreClass.turn();
                        continue;
                    





                }

                if (aManticoreClass.City <= 0) {
                    Console.Clear();
                    Console.WriteLine("You lose!");
                    break;
                }
                else if (aManticoreClass.Manticore <= 0)
                {
                    Console.Clear();
                    Console.WriteLine("You Win!");
                    break;
                }
                else {
                    Console.Clear();
                    Console.WriteLine("Game Over");
                    break;
                }
                   

              
                   
            }

        }
    }
}
