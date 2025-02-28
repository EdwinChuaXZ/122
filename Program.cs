//written by Edwin
//2/26

namespace Library_System
{
    public class Program
    {
        static void Main(string[] args)
        {

            //use subclass
            Ebook aEbook = new Ebook("BookName1", "Edwin", 2015, 400);
            PrintedBook aPrintedBook = new PrintedBook("BookName2 ", "Chua", 2009,100);


            //output
            Console.WriteLine(aEbook);
            Console.WriteLine(aPrintedBook);
        }
    }
}
