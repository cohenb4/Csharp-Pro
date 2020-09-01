using System;
using System.Threading;
/*Programmer: Brendan Cohen
 * Date: 5/24/20
 * 
 * This program allows a user to enter a number of scores they choose and in turn 
 * calculates the average as well as gives user score deviations
 * 
 */
namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int number; //declares number
            int count = 0; //sets count = 0
            double [] score = new double [100]; //allows up to 100 scores
            double total = 0; //sets score = 0
            double average; //allows up to 100 scores


            Console.Write("How many scores are you going to enter: ");
            number = int.Parse(Console.ReadLine());

            while(count < number)
            {
                Console.Write("enter a score: ");
                score[count] = double.Parse(Console.ReadLine());

                total = total + score[count];

                count++;
            }

            average = total / number;

            Console.WriteLine("Average score is " + average);

            for(int i = 0; i < count; i++)
            {
                Console.Write("Score " + (i + 1));
                Console.WriteLine(" deviates from the average by " + (average - score[i]));
            }

        }
    }
}
