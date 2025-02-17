//Edwin Chua
//2/15/2025
namespace Simula_s_Soup
{
    public class SoupProgram
    {
        
        public static void Main(string[] args)
        {
            SoupClass asoupClass = new SoupClass();

            //input
            Console.WriteLine("Select type: soup, stew, bumbo");
            string choose1 = Console.ReadLine().ToLower();

           asoupClass.Choose1 = choose1;

            Console.WriteLine("Select Ingredients: mushrooms, chicken, carrots, potatoes");
            string choose2 = Console.ReadLine().ToLower();
            asoupClass.Choose2 = choose2;

            Console.WriteLine("Select seasonings: spicy, salty, sweet");
            string choose3 = Console.ReadLine().ToLower();
            asoupClass.Choose3 = choose3;

            //output
            Console.WriteLine(asoupClass.ToString());

        }
    }
}
