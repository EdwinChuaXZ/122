namespace The_Properties_of_Arrows
{
    internal class PropertiesProgram
    {
        static void Main(string[] args)
        {
            PropertiesClass1 aVinPrivateClass1 = new PropertiesClass1();


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
