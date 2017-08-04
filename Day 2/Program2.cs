using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_2
{
    class Program2
    {
        static void Main()
        {
            int x = 20;
            int y = 3;

            Console.WriteLine("20/3 = {0}", x / y); // 6 because it's integer division
            Console.WriteLine("20/3 = {0}", 1.0 * x / y); // 1.0 to make it into a double division
            Console.WriteLine("Remainder = {0}", x % y);

            double xx = 20.0;
            double yy = 3.0;

            Console.WriteLine("20/3 = {0}", xx / yy); // 6.6 because it's not integer division
            Console.WriteLine("Remainder = {0}", xx % yy);

        }
    }
}
