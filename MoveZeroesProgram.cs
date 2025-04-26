//written by Edwin
//4/24
namespace Move_Zeroes
{
    internal class MoveZeroesProgram
    {
        static void Main(string[] args)
        {
            MoveZeroesClass1 aMoveZeroesClass1 = new MoveZeroesClass1();

            int[] nums = { 0, 1, 0, 3, 12 };
            aMoveZeroesClass1.MoveZeroes(nums);

            Console.WriteLine(string.Join(",",nums));
        }
    }
}
