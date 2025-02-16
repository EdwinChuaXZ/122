// Written by Edwin
//2/10/2025

namespace Array_of_integers
{
    internal class FindAbsSumProgram
    {
      
        static void Main(string[] args)
        {
            //input
            List<int> aList = new List<int> { 2, -1, 4, 8, 10 };
            List<int> aList2 = new List<int> { -3, -4, -10, -2, -3 };
            List<int> aList3 = new List<int> { 2, 4, 6, 8, 10 };
            List<int> aList4 = new List<int> { -1};
            FindAbsSumClass aFindSum = new FindAbsSumClass();


            //output
            Console.WriteLine(aFindSum.FindABSSum(aList));
            Console.WriteLine(aFindSum.FindABSSum(aList2));
            Console.WriteLine(aFindSum.FindABSSum(aList3));
            Console.WriteLine(aFindSum.FindABSSum(aList4));
        
        }
    }
}
