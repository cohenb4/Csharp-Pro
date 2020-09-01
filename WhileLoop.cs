using System;

/*Programmer: Brendan Cohen
 * Date written 5/13/20
 * 
 * This program is designed to demonstrate how a while loop works
 * 
 */

namespace WhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            int number =0;
            int temp;

            while(number <= 10)
            {
                Console.WriteLine(number);
                number += 1;
            }
        }
    }
}
