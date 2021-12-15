using System;

namespace rustShakeOff
{
    //User defined class, every class has at least one class
    //keyword class is immediately followed by the class name (Program in this case).
    //Class names should always start with a capital letter
    class Program
    {
        static void Main()
        {
           //Pg 42 Program
           // Console.WriteLine("Welcome to C# Progamming!");

           //Pg 53 Program - Write vs WriteLine
           //Console.Write("Welcome to ");
           //Console.WriteLine("C# Programming!");

           //Pg 54 Program - Learning newline chars
           //Console.Write("Welcome \n to C# \n Programming \n !");
           // \n newline - \t tab - \" print quotes
           
           //Pg 55 Program - String interpolation
           //string person = "Mark";
           //Console.WriteLine($"Welcome to C# Progamming, {person}!"); //$ allows for interpolation to be seen in the quotes

           //pg 56 Program - Adding Integers
           /*int num1;
           int num2;
           int sum;

           Console.WriteLine("Enter first int: ");
           num1 = int.Parse(Console.ReadLine());

           Console.WriteLine("Enter Second int: ");
           num2 = int.Parse(Console.ReadLine());

           sum = num1 + num2;

           Console.WriteLine($"Sum is {sum}");
           */

            //Pg 69 - Account Class *note: Need to create class Account with Get Set Functions
            Account myAccount = new Account();

            Console.WriteLine($"Initial name is: {myAccount.GetName()}");

            Console.Write("Enter the name: ");
            string theName = Console.ReadLine();
            myAccount.SetName(theName);

            Console.WriteLine($"myAccount's name is: {myAccount.GetName()}");
            


        }
    }
}
