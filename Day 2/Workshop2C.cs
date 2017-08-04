using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_2
{
    class Workshop2C
    {
        static void Main()
        {
            /* Question 1
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Please enter your gender (M/F): ");
            string gender = Console.ReadLine();

            if (gender == "M" || gender == "Male")
            {
                Console.WriteLine("Good Morning Mr {0}", name);
            }
            else if (gender == "F" || gender == "Female")
            {
                Console.WriteLine("Good Morning Ms {0}", name);
            }
            else
            {
                Console.WriteLine("Please enter either M or F for gender");
            }
            */

            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Please enter your gender (M/F): ");
            string gender = Console.ReadLine();
            Console.Write("Please enter your age :");
            string input = Console.ReadLine();
            double age = Convert.ToDouble(input);


            // test line to commit

            if (gender == "M" || gender == "Male")
            {
                if (age >= 40)
                {
                    Console.WriteLine("Good Morning Uncle {0}", name);
                }
                else
                {
                    Console.WriteLine("Good Morning Mr {0}", name);
                }
            }
            else if (gender == "F" || gender == "Female")
            {
                Console.WriteLine("Good Morning Ms {0}", name);
            }
            else
            {
                Console.WriteLine("Please enter either M or F for gender");
            }



            //Console.Write("Enter length of A: ");
            //string input = Console.ReadLine();
            //double A = Convert.ToDouble(input);

            //Console.Write("Enter length of B: ");
            //string input2 = Console.ReadLine();
            //double B = Convert.ToDouble(input2);

            //Console.Write("Enter length of C: ");
            //string input3 = Console.ReadLine();
            //double C = Convert.ToDouble(input3);

            //double S = ((A + B + C) / 2);

            //if ((A + B) > C && (A + C) > B && (B + C) > A)
            //{
            //    Console.WriteLine("Area = {0}", Math.Sqrt(S * (S - A) * (S - B) * (S - C)));

            //}
            //else
            //{
            //    Console.WriteLine("Not a valid triangle.");
            //}

        }

    }
}
