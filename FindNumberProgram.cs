//Written by Edwin
//2/10/25

namespace Smallest_and_Biggest_Numbers
{
    public class FindNumberProgram
    {
        static void Main(string[] args)
        {
            //arry num

            List<int> aList1 = new List<int> { 1, 2, 3, 4, 5 };
            List<int> aList2 = new List<int> { 2334454, 5 };
            List<int> aList3 = new List<int> { 1 };


            FindNumberClass aFindNumber = new FindNumberClass();



            //use Join function 
            Console.WriteLine(string.Join(",",aFindNumber.FindMaxMin(aList1)));
            Console.WriteLine(string.Join(",", aFindNumber.FindMaxMin(aList2)));
            Console.WriteLine(string.Join(",",aFindNumber.FindMaxMin(aList3)));


        }
    }
}
