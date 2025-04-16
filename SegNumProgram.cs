//written by Edwin
//4/9
namespace Number_of_Segments_in_a_String
{
    internal class SegNumProgram
    {
        static void Main(string[] args)
        {
            SegNumClass1 aSegNumClass1 = new SegNumClass1();

            string s = "Hello, my name is John";

            int ans = aSegNumClass1.CountSegments(s);

            Console.WriteLine(ans);
        }
    }
}
