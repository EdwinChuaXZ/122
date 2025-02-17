namespace Vin_s_Trouble
{
    internal class VinPrivateProgram
    {
        static void Main(string[] args)
        {

            VinPrivateClass1 aVinPrivateClass1 = new VinPrivateClass1();


            //output and input
            Console.WriteLine("Choose: steel, wood, obsidia");

            string aArrowhead1 = Console.ReadLine();

            aVinPrivateClass1.IArrowhead = aArrowhead1;

            Console.WriteLine("Choose: plastic, turkey, goose");

            aVinPrivateClass1.IFletch = Console.ReadLine();

            Console.WriteLine("Enter Length:");
            double Length = double.Parse(Console.ReadLine());
            aVinPrivateClass1.Length = Length;

            Console.WriteLine(aVinPrivateClass1.ToString());
        }
    }
}
