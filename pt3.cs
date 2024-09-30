using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nitrate_Problem
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double nitrate = 0.0;

            Console.WriteLine("Enter the amount of nitrate");
            nitrate = Convert.ToDouble(Console.ReadLine());

            if (nitrate > 10) 
            {
                Console.WriteLine("For {0} nitrate, dose 3 ml", nitrate);
                Console.ReadLine();
            }

            if (nitrate < 10) 
            {
                if (nitrate > 2.5) 
                {
                    Console.WriteLine("For {0} nitrate, dose 2 ml", nitrate);
                    Console.ReadLine();
                }
            }
            if (nitrate < 2.5) 
            {
                if (nitrate > 1) ;
                {
                    Console.WriteLine("For {0} nitrate, dose 1 ml", nitrate);
                }
                
            }
            else
            {
                Console.WriteLine("For {0} nitrate, dose 0.5 ml", nitrate);
            }

        }   
    }
}
