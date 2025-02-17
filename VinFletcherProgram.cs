//Written by Edwin
//2/16

namespace Vin_Fletcher_s_Arrows
{
    public class VinFletcherProgram
    {
        public static void Main(string[] args)
        {


            VinFletcherClass1 aVinFletcherClass1 = new VinFletcherClass1();


            //output and input
            Console.WriteLine("Choose: steel, wood, obsidia");

            string aArrowhead1 = Console.ReadLine();

            aVinFletcherClass1.IArrowhead = aArrowhead1;

            Console.WriteLine("Choose: plastic, turkey, goose");

            aVinFletcherClass1.IFletch = Console.ReadLine();

            Console.WriteLine("Enter Length:");
            double Length = double.Parse(Console.ReadLine());
            aVinFletcherClass1.Length = Length;

            Console.WriteLine(aVinFletcherClass1.ToString());   
        }
    }
}
