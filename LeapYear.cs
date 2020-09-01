using System;
/*Programmer: Brendan Cohen
 * Date written: 5/13/20
 * 
 * This program is used to determine whether or not the year is a leap year
 * 
 */

namespace LeapYear
{
    class Program
    {
        static void Main(string[] args)
        {
            int year;

            Console.Write("What year is it? "); //prompts the user for the year
            year = int.Parse(Console.In.ReadLine()); //input the year

            Console.Clear();


            if (year % 400 == 0)
                Console.WriteLine("This is a Leap year");
            else if (year % 100 == 0)
                Console.WriteLine("This is not a Leap year");
            else if (year % 4 == 0)
                Console.WriteLine("This is a Leap year");
            else
                Console.WriteLine("This is not a Leap year");
        }
    }
}
