using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_2
{
    class Workshop2B
    {
        static void Main()
        {
            /* Question 1
            Console.Write("Please enter the double precision number: ");
            string input = Console.ReadLine();
            double number = Convert.ToDouble(input);
            Console.WriteLine("{0:0.###}", Math.Sqrt(number));
            */

            /* Question 2 
            Console.Write("Please enter the double precision number: ");
            string input = Console.ReadLine();
            double number = Convert.ToDouble(input);
            Console.WriteLine("{0:0.000}", Math.Round(Math.Sqrt(number),3));
            */

            /* Question 3
            Console.Write("Please enter your salary: ");
            string input = Console.ReadLine();
            double salary = Convert.ToDouble(input);

            Console.WriteLine("Salary is {0:c}", salary);
            Console.WriteLine("Housing allowance is {0:c}", 0.10*salary);
            Console.WriteLine("Transport allowance is {0:c}", 0.03*salary);
            Console.WriteLine("Total income is {0:c}", salary + 0.13*salary);
            */

            /* Question 4
            Console.Write("Enter Centigrade: ");
            string input = Console.ReadLine();
            double centigrade = Convert.ToDouble(input);

            Console.WriteLine("Farenheit is {0}", centigrade * 1.8 + 32);
            */

            /* Question 5
            Console.Write("Enter value of x: ");
            string input = Console.ReadLine();
            double x = Convert.ToDouble(input);

            Console.WriteLine("y = {0}", 5*Math.Pow(x,2) - 4 * x + 3);
            */

            /* Question 6
            Console.Write("Enter value of X1: ");
            string input = Console.ReadLine();
            double x1 = Convert.ToDouble(input);

            Console.Write("Enter value of X2: ");
            string input2 = Console.ReadLine();
            double x2 = Convert.ToDouble(input2);

            Console.Write("Enter value of Y1: ");
            string input3 = Console.ReadLine();
            double y1 = Convert.ToDouble(input3);

            Console.Write("Enter value of Y2: ");
            string input4 = Console.ReadLine();
            double y2 = Convert.ToDouble(input4);

            Console.WriteLine("Distance is: {0}", Math.Sqrt(Math.Pow(x2-x1,2) + Math.Pow(y2-y1,2)),2);
            */

            /* Question 7
            Console.Write("Enter distance: ");
            string input = Console.ReadLine();
            double distance = Convert.ToDouble(input);

            Console.WriteLine("Fare is {0}", 2.4 + distance * 0.4);
            */

            /* Question 8
            Console.Write("Enter distance: ");
            string input = Console.ReadLine();
            double distance = Convert.ToDouble(input);

            double fare = 2.4 + distance * 0.4;

            Console.WriteLine("Fare is {0:0.00}", Math.Round(fare,1));
            */

            /* Question 9
            Console.Write("Enter distance: ");
            string input = Console.ReadLine();
            double distance = Convert.ToDouble(input);

            double fare = 2.4 + distance * 0.4;

            Console.WriteLine("Fare is {0:0.0}", Math.Ceiling(fare*10)/10);
            */

            // Question 10
            Console.Write("Enter length of A: ");
            string input = Console.ReadLine();
            double A = Convert.ToDouble(input);

            Console.Write("Enter length of B: ");
            string input2 = Console.ReadLine();
            double B = Convert.ToDouble(input2);

            Console.Write("Enter length of C: ");
            string input3 = Console.ReadLine();
            double C = Convert.ToDouble(input3);

            double S = ((A + B + C) / 2);

            if ((A + B) > C && (A + C) > B && (B + C) > A)
            {
                Console.WriteLine("Area = {0}", Math.Sqrt(S * (S - A) * (S - B) * (S - C)));

            }
            else
            {
                Console.WriteLine("Not a valid triangle.");
            }

        }

    }
}
