﻿// written by Edwin
// 2/6/2025
namespace Discounted_Inventory
{
    public class Program
    {
        static void Main(string[] args)
        {
            CMENU ACMENU = new CMENU();

            //input and ouput

            Console.WriteLine("The following item are available ： " + "\n");
            Console.WriteLine("1 - Rope" + "\n");
            Console.WriteLine("2 - Torches" + "\n");
            Console.WriteLine("3 - Climbing Equipment" + "\n");
            Console.WriteLine("4 - Clean Water" + "\n");
            Console.WriteLine("5 - Machete" + "\n");
            Console.WriteLine("6 - Canoe" + "\n");
            Console.WriteLine("7 - Food Supplies" + "\n");
            Console.WriteLine("What number do you want to see the price of ? " + "\n");
            int aUserinput = Convert.ToInt32(Console.ReadLine());// input choose num

            Console.WriteLine("PLS enter your name : \n");
            string aname = Console.ReadLine();// input name

            
            ACMENU.Userinput = aUserinput;
            ACMENU.Username = aname;


            Console.WriteLine(ACMENU.ToString());
        }
    }
}
