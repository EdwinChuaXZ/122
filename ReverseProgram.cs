//written by Edwin
//4/24
namespace Reverse_String
{
    internal class ReverseProgram
    {
        static void Main(string[] args)
        {
            ReverseClass1 aReverseClass1 = new ReverseClass1();

            char[] s = { 'H','e','l','l','o'};

            aReverseClass1.ReverseString(s);



            Console.WriteLine(s);
        }
    }
}
