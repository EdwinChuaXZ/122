// Wiritten by Edwin Chua
//4/1
namespace Merge_Two_Sorted_Arrays
{
    internal class MergeProgram
    {
        static void Main(string[] args)
        {
            MergeTwo mergeTwo = new MergeTwo();

            int[] num1 = new int[3] { 1,2,3};
            int[]num2 = new int[3] {4,5,6};

            int m = 3, n = 3;
            
            mergeTwo.Merge(num1,m,num2,n);



            Console.WriteLine(string.Join(",",num1 ));
        }
    }
}
