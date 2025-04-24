//Written by Edwin
//4/15
namespace Find_Pivot_Index
{
    internal class FindPivotProgram
    {
        static void Main(string[] args)
        {
            FindPivotClass1 aFindPivotClass1 = new FindPivotClass1();

            int[] nums = { 1, 7, 3, 6, 5, 6 };

            int ans = aFindPivotClass1.PivotIndex(nums);


            Console.WriteLine(ans);
        }
    }
}
