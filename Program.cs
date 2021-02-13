using System;

namespace Cenfotec.LeapYear
{
    class Program
    {
        static void Main(string[] args)
        {
            var endProgram = false;

            while (!endProgram)
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("Please enter the year you want to check: ");
                    
                    var isNumber = int.TryParse(Console.ReadLine(), out int year);

                    if (isNumber)
                    {
                        Console.WriteLine(DateTime.IsLeapYear(year) ? $"{year} Leap Year!" : $"{year} Not a Leap Year!");
                    }
                    else
                    {
                        Console.WriteLine("Input not valid, please try again!");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Something went wrong, there was an issue running the application.");
                    Console.WriteLine(e.Message);
                }

                var userResponse = string.Empty;

                while (string.IsNullOrEmpty(userResponse))
                {
                    Console.WriteLine("Do you want to try out other year? (Yes, No)");
                    var response = Console.ReadLine()?.ToLower()?[0] ?? 'e';

                    userResponse = response == 'y' ? "y" : response == 'n' ? "n" : string.Empty;
                }

                endProgram = userResponse.Equals("n");
            }

            Console.WriteLine("Thanks!, See you soon.");
            Console.ReadLine();
        }
    }
}
