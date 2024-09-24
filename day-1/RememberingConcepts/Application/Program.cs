using System;

namespace RememberingConcepts
{
    internal class Program
    {
        static void Main(string[] _)
        {

            Console.WriteLine("Welcome to my Application");
            
            Console.WriteLine("Enter Your Name: ");
            string? name = Console.ReadLine();

            int myInt = 420;
            decimal myDecimal = 420.0m;
            double myDouble = 420.0d;

            byte b = 124;

            string firstName = "Ryan";
            string lastName = "G";
            string fullName = firstName + " " + lastName;
            Console.WriteLine("Hell There My Name is: {0}", fullName);


            Console.ReadLine();
        }
    }
}
