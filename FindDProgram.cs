//written by Edwin
//2/10/2025
    namespace how_many_D_s
{

    internal class FindDProgram
    {
        static void Main(string[] args)
        {
            FindDClass aClass = new FindDClass();
            // input
            string CountDs1 = "My friend Dylan got distracted in school.";
            string CountDs2 = "Debris was scattered all over the yard.";
            string CountDs3 = "The rodents hibernated in their den.";


            //output
            Console.WriteLine(aClass.FindD(CountDs1));
            Console.WriteLine(aClass.FindD(CountDs2));
            Console.WriteLine(aClass.FindD(CountDs3));
        }
    }
}
