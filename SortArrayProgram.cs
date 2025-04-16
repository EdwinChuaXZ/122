//written by Edwin
//4/1
namespace Sort_Array_By_Parity
{
    internal class SortArrayProgram
    {
        static void Main(string[] args)
        {
            Solution aSolution = new Solution();

            int[] nums = { 3,1,2,4};

            int[] sor = aSolution.SortArrayByParity(nums);

            Console.WriteLine(string.Join(",", sor));
        }
    }
}
