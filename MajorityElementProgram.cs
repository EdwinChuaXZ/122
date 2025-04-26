//written by Edwin
//4/24
namespace Majority_Element
{
    internal class MajorityElementProgram
    {
        static void Main(string[] args)
        {
            MajorityElementClass1 aMajorityElementClass1 = new MajorityElementClass1();

            int[] nums = { 3, 2, 3 };

            int ans = aMajorityElementClass1.MajorityElement(nums); 
            Console.WriteLine(ans);
      
        }
    }
}
