//Writting by Edwin
//2/6/2025
namespace Discounted_Inventory
{
    internal class DiscountProgram
    {
        static void Main(string[] args)
        {
            DiscountClass aDiscountClass = new DiscountClass();

            //menu:
            // output and input
            Console.WriteLine("The following items are available: ");
            Console.WriteLine("1 - Rope");
            Console.WriteLine("2 - Torches");
            Console.WriteLine("3 - Climbing Equipment");
            Console.WriteLine("4 - Clean Water");
            Console.WriteLine("5 - Machete");
            Console.WriteLine("6 -Canoe");
            Console.WriteLine("7 - Food Supplies");
            Console.WriteLine("What number do you want to see the price of?");
            aDiscountClass.Choose = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Pls enter your name: ");
            aDiscountClass.Name = Console.ReadLine();

            Console.WriteLine(aDiscountClass.ToString());
        }
    }
    
}
