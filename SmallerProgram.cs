//Written by Edwin
//2/10/25
namespace Returns_smaller_number
{
    internal class SmallerProgram
    {
        static void Main(string[] args)
        {
            //Input
            List<int> aList = new List<int> { 21, 44 };
            List<int> aList2 = new List<int> { 1500, 1 };
            List<int> aList3 = new List<int> { 5, 5 };
            SmallerClass aClass1 = new SmallerClass();

            //Output
            Console.WriteLine(aClass1.FindSmaller(aList));
            Console.WriteLine(aClass1.FindSmaller(aList2));
            Console.WriteLine(aClass1.FindSmaller(aList3));
        }
    }
}
