//Writting by Edwin
//2/6/2025
namespace Buying_Inventory
{
    public class BuyingInventoryProgram
    {
        public static void Main(string[] args)
        {   // use class
            BuyingInventoryClass aBuyingInventoryClass = new BuyingInventoryClass();

            //menu:
            // output and input
            Console.WriteLine("The following items are available: ");
            Console.WriteLine("1 - Rope");
            Console.WriteLine("2 - Torches");
            Console.WriteLine("3 - Climbing Equipment");
            Console.WriteLine("# - Clean Water");
            Console.WriteLine("5 - Machete");
            Console.WriteLine("6 -Canoe");
            Console.WriteLine("7 - Food Supplies");
            Console.WriteLine("What number do you want to see the price of?");
            aBuyingInventoryClass.Choose = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(aBuyingInventoryClass.ToString());
        }
    }
}
