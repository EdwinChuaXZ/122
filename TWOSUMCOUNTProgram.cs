// Wiritten by Edwin Chua
//4/1

namespace Two_Sum
{
    internal class TWOSUMCOUNTProgram
    {
        static void Main(string[] args)
        {
            TWOSUMCOUNT TWOSUMCOUNT1 = new TWOSUMCOUNT();

            //test number
            int[] nums = { 3,2,4 };
            int target = 6;

            //Pass the array to the method and get the answer.
            int[] number = TWOSUMCOUNT1.TwoSum(nums, target);

            //Using string.Join output array
            Console.WriteLine(string.Join(",",number));
        }
    }
}
