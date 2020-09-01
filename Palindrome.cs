using System;

/*Programmer: Brendan Cohen
 * Date: 5/15/20
 * 
 * This program is used to determine if a number is a palindrome or not
 * 
 */

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            int tnumber;
            int rem;
            int rev;
            
            Console.Write("Enter a number: "); //prompt the user for a number
            number = int.Parse(Console.In.ReadLine()); //input the number           

            Console.Clear();

            tnumber = number;

            rev = tnumber;

            while (number > 0)
            {

                rem = number % 10;
                rev = rev * 10 + rem;
                number = number / 10;
            
            }

            if (rev == tnumber)
                Console.WriteLine("Number is Palindrome");
            else
                Console.WriteLine("Number is not a Palindrome");

        }
    }
}

