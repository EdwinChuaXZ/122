//Written by Edwin
//4/15
namespace Number_of_Students_Unable_to_Eat_Lunch
{
    internal class NumOfSTDProgram
    {
        static void Main(string[] args)
        {
            NumofStudentLuchClass1 aNumofStudentLuchClass1 = new NumofStudentLuchClass1();

            //int[] students, int[] sandwiches
            int[] students = { 1, 1, 1, 0, 0, 1 };
            int[] sandwiches = { 1, 0, 0, 0, 1, 1 };

            int ans = aNumofStudentLuchClass1.CountStudents(students, sandwiches);
            Console.WriteLine(ans);
        }
    }
}
