//written by Edwin
//4/9
namespace First_Unique_Character_in_a_String
{
    internal class UniqueCharacterProgram
    {
        static void Main(string[] args)
        {
            UniqueCharacterClass1 aUniqueCharacterClass1 = new UniqueCharacterClass1();

            string s = "lobeleetcode";

            int ans = aUniqueCharacterClass1.FirstUniqChar(s);


            Console.WriteLine(ans);
        }
    }
}
