using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Programmer: Brendan Cohen
 * Date written 5/13/20
 * 
 * The program will prompt the user for their first name and then use it to welcome the student to the Summer Semester of 2020 of IS 3050
 * 
 */

namespace ConsoleApp20
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;  //declare variable to hold the student's first name

            Console.Write("Please enter your first name ");  //prompt the user for their first name

            name = Console.In.ReadLine();  //input the user's first name

            Console.Clear();

            //output greeting
            Console.Write(name);
            Console.WriteLine(" Welcome to IS 3050 Summer 2020");
        }
    }
}
