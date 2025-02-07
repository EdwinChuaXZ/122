//Writting by Edwin
//2/6/2025
using System.Diagnostics.Metrics;

namespace The_Prototype
{
    internal class ThePrototypeProgram
    {
        static void Main(string[] args)
        {
            ThePrototypeClass1 aThePrototypeClass1 = new ThePrototypeClass1();

            //menu:
            // output and input


            while (true)
            {
                Console.Clear();//delete last infor
                // if pilot input more tha the range, run again
                Console.WriteLine("User1, enter a number between 0 and 100");
                int apilot = Convert.ToInt32(Console.ReadLine());

                if (apilot >= 0 && apilot <= 100)
                {
                    aThePrototypeClass1.Pilot = apilot; Console.Clear(); break; // stop run again , go to next step
                }


                else { Console.WriteLine("Input Error!");Console.Clear(); continue; }

            }

            while (true)
            {
               

                // hunter input
                Console.WriteLine("User2 :");
                int ahunter = Convert.ToInt32(Console.ReadLine());

                aThePrototypeClass1.Hunter = ahunter;

                //if correct , end program
                if (ahunter == aThePrototypeClass1.Pilot)
                {
                    


                    Console.WriteLine(aThePrototypeClass1.ToString()); break;
                }

                //if not, ask again
              
                else
                { Console.WriteLine(aThePrototypeClass1.ToString()); continue; }


                }

        }
                   

                
            

        }
    }

