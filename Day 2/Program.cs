using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_2
{
    class Quiz
    {
        static void Main(string[] args)
        {
            System.Console.Write("Please enter the length in cm: ");
            string input = System.Console.ReadLine();
            double length = System.Convert.ToDouble(input);
          //double length = Convert.ToDouble(Console.Readline());    // Alternative to nest the commands together
            double lengthInInch = length / 2.54;
            System.Console.WriteLine("{0:0.000}", lengthInInch);
        }
    }
}
