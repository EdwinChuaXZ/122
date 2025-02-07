namespace The_Prototype
{
    public class Program
    {
        static void Main(string[] args)
        {
            Guess aGuess = new Guess();


            

            while (true)
            {//Determine whether to continue

                Console.WriteLine("User1, enter a number between 0 and 100:");
                int apilot = Convert.ToInt32(Console.ReadLine()); // pilot num input

                if (apilot < 0 || apilot > 100) { Console.WriteLine("number between 0 and 100"); Console.Clear(); continue; } //clear and run again

                else if (apilot > 0 || apilot < 100)
                {
                    Console.Clear();
                    Console.WriteLine("Pilot enter num:");

                    int ahunter = Convert.ToInt32(Console.ReadLine()); // hunter num input

                    if ((ahunter == apilot)) { Console.WriteLine("You guess the number!"); break; }


                    while (ahunter !=apilot)
                    { // hunter: Determine whether to continue

                        

                    if (ahunter > apilot) { Console.WriteLine(ahunter + "is too high."); }

                    else { Console.WriteLine(ahunter + "is too low.");}
                }
                    break;//end second while

                }

                }
          
        }
    }
}
