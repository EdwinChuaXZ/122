//Edwin Chua
//2/15/2025
namespace Simula_s_Test
{
    internal class SimulaProgram
    {
        static void Main(string[] args)
        {
            SimulaClass aSimulaClass = new SimulaClass();

            //loop

            while (true)
            {
                Console.WriteLine("What do you want to do? ");

                //Make the input value uppercase

                string choose = Console.ReadLine().ToUpper();

                //Determine whether the input is correct
                //If correct run next step, if wrong re-enter

                if (choose =="LOCK" || choose=="CLOSE" || choose == "OPEN")
            {
                aSimulaClass.Choose = choose;

                    Console.WriteLine(aSimulaClass.ToString()); continue;

                }
            else { Console.WriteLine("Plese enter correct! "); continue;}
            }
            

        }
    }
}
