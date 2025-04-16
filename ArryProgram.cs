// Wiritten by Edwin Chua
//4/1
namespace Remove_Element_From_Array
{
    internal class ArryProgram
    {
        static void Main(string[] args)
        {
            Arry Arry1 = new Arry();

            //test number
            int[] nums = { 3, 2, 4 ,2,1};
            int val = 2;

            //Pass the array to the method and get the answer.
            int number = Arry1.RemoveElement(nums, val);

            //Using string.Join output array
            Console.WriteLine(number);
        }
    }
}
