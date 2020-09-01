using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace Age_Program
/*Programmer: Brendan Cohen
 * Date: 5/24/20
 * 
 * This program allows user to be able to 
 * see the average age of a group of students
 * 
 */
{
    class Program
    {
        public static void Main(string[] args)
        {
            printmessage();
        }
        static void printmessage()
        {
            Console.WriteLine("IS 3050");
            Console.WriteLine("Class Age Report");
            Console.WriteLine(" ");
            Console.WriteLine("Name birth year question year");

            studentReport();
        }
        public static void studentReport()    
        {


                String line;
                String[] x;

                using (StreamReader student = File.OpenText("Student.txt"))
                {
                    using (StreamWriter studentout = File.CreateText("studentreport.txt"))
                    {
                    int total = 0;
                    int count = 0;

                        while ((line = student.ReadLine()) != null)
                        {
                            x = line.Split(',');

                            Console.Write(x[0] + ",");
                            Console.WriteLine(x[1] + "," + x[2]);

                            int age = int.Parse(x[2]) - int.Parse(x[1]);
                            
                            count++;
                            total += age;
                        }

                    averageAge(count, total);
                        
                        student.Close();
                        studentout.Close();
                    }
                }
            static void averageAge(int count, int total)
            {
                double average = total / count;

                footer(average);
            }
            static void footer(double average)
            {
                Console.WriteLine("Average age " + average);
            }
            }
        }
        
}
            
        
        
        
            
        
    

