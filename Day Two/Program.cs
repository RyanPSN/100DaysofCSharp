using System;

namespace Day_2
{
    class Program
    {
        static void Main(string[] _)
        {
            if (_.Length.Equals(0))
            {
                double rate = 15.00;
                int numberHoursWorked = 3;

                numberHoursWorked += 3;
                double calculationHours = rate * numberHoursWorked;

                if (calculationHours > 60)
                {
                    Console.WriteLine("Your a Paid Employee");
                }


                //char userSelection = 'a';

                //char upperCaseSelection = char.ToUpper(userSelection);
                //bool isDigit = char.IsDigit(userSelection);
                //bool isLetter = char.IsLetter(userSelection);

                // DateTime d = new DateTime(2024, 9, 24, 14, 25, 0); ;
                // DateTime e = new DateTime(2024, 12, 9);

                // long l = numberHoursWorked;
                // double d1 = 123456789.0d;

               // int x = (int)d1;

                var a = 1337;
                var b = false;
                var d = 1337.00;


                //int varyLongMonth = (int)l;

                //Console.WriteLine(x);
                //Console.WriteLine(varyLongMonth);
                
                Console.WriteLine(calculationHours);
                Console.ReadLine();
            }
        }
 
    }

}