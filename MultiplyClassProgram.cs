// Written by Edwin
//2/10/2025
namespace Multiply
{
    internal class MultiplyClassProgram
    {
        
        static void Main(string[] args)
        {
            //input
            List<int> aList = new List<int> { 2, 3, 1, 0 };
            List<int> aList2 = new List<int> { 4, 1, 1 };
            List<int> aList3= new List<int> { 1, 0, 3, 3, 7, 2, 1 };
            List<int> aList4 = new List<int> {0 };

            MultiplyClass aMultiply = new MultiplyClass();

            //output
            Console.WriteLine(string.Join(",",aMultiply.FindMul(aList)));
            Console.WriteLine(string.Join(",", aMultiply.FindMul(aList2)));
            Console.WriteLine(string.Join(",", aMultiply.FindMul(aList3)));
            Console.WriteLine(string.Join(",", aMultiply.FindMul(aList4)));
        }
    }
}
