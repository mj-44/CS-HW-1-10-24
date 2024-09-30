using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_Format
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string day = "";
            string format = "";

            Console.WriteLine("Enter the number of the day");
            day = Console.ReadLine();

            Console.WriteLine("Enter the format (shortday, day or char)");
            format = Console.ReadLine();

            if (format == "shortday")
            {

                if (day == "1")
                {
                    Console.WriteLine("Mon");
                    Console.ReadLine();
                }
                if (day == "2")
                {
                    Console.WriteLine("Tue");
                    Console.ReadLine();
                }
                if (day == "3")
                {
                    Console.WriteLine("Wed");
                    Console.ReadLine();
                }
                if (day == "4")
                {
                    Console.WriteLine("Thu");
                    Console.ReadLine();
                }
                if (day == "5")
                {
                    Console.WriteLine("Fri");
                    Console.ReadLine();
                }
                if (day == "6")
                {
                    Console.WriteLine("Sat");
                    Console.ReadLine();
                }
                if (day == "7")
                {
                    Console.WriteLine("Sun");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Invalid day input");
                    Console.ReadLine();
                }
            }
            if (format == "day")
            {

                if (day == "1")
                {
                    Console.WriteLine("Monday");
                    Console.ReadLine();
                }
                if (day == "2")
                {
                    Console.WriteLine("Tuesday");
                    Console.ReadLine();
                }
                if (day == "3")
                {
                    Console.WriteLine("Wednesday");
                    Console.ReadLine();
                }
                if (day == "4")
                {
                    Console.WriteLine("Thursday");
                    Console.ReadLine();
                }
                if (day == "5")
                {
                    Console.WriteLine("Friday");
                    Console.ReadLine();
                }
                if (day == "6")
                {
                    Console.WriteLine("Saturday");
                    Console.ReadLine();
                }
                if (day == "7")
                {
                    Console.WriteLine("Sunday");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Invalid day input");
                    Console.ReadLine();
                }
        
            }
            if (format == "char")
            {

                if (day == "1")
                {
                    Console.WriteLine("M");
                    Console.ReadLine();
                }
                if (day == "2")
                {
                    Console.WriteLine("Tu");
                    Console.ReadLine();
                }
                if (day == "3")
                {
                    Console.WriteLine("W");
                    Console.ReadLine();
                }
                if (day == "4")
                {
                    Console.WriteLine("Th");
                    Console.ReadLine();
                }
                if (day == "5")
                {
                    Console.WriteLine("F");
                    Console.ReadLine();
                }
                if (day == "6")
                {
                    Console.WriteLine("Sa");
                    Console.ReadLine();
                }
                if (day == "7")
                {
                    Console.WriteLine("Su");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Invalid day input");
                    Console.ReadLine();
                }
            }
            else
            {
                Console.WriteLine("Invalid input");
                Console.ReadLine();
            }
            }
        }
}
