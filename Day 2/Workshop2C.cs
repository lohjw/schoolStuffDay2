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

            /* Question 2
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Please enter your gender (M/F): ");
            string gender = Console.ReadLine();
            Console.Write("Please enter your age: ");
            string input = Console.ReadLine();
            double age = Convert.ToDouble(input);


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
                if (age >= 40)
                {
                    Console.WriteLine("Good Morning Aunty {0}", name);
                }
                else
                {
                    Console.WriteLine("Good Morning Ms {0}", name);
                }
            }
            else
            {
                Console.WriteLine("Please enter either M or F for gender");
            }
            */

            /* Question 3
            Console.WriteLine("Enter the number grade: ");
            double noGrade = double.Parse(Console.ReadLine());

            string grade = "";
            // if between 80 - 100 A
            if (noGrade < 0 || noGrade > 100)
            {
                Console.WriteLine("Error");
            }
            else if (noGrade >= 80 && noGrade <= 100)
            {
                grade = "A";
                Console.WriteLine("You scored {0} marks which is is {1} grade", noGrade, grade);

            }
            // 60 - 79
            else if (noGrade >= 60 && noGrade < 80)
            {
                grade = "B";
                Console.WriteLine("You scored {0} marks which is is {1} grade", noGrade, grade);

            }
            // 40 to 59
            else if (noGrade >= 40 && noGrade < 60)
            {
                grade = "C";
                Console.WriteLine("You scored {0} marks which is is {1} grade", noGrade, grade);

            }
            // 0 to 39* instead of 40, typo in question?
            else if (noGrade >= 0 && noGrade < 40)
            {
                grade = "F";
                Console.WriteLine("You scored {0} marks which is is {1} grade", noGrade, grade);

            }
            */

            /* Question 4
            Console.Write("Please enter distance travelled (in km): ");
            string input = Console.ReadLine();
            double km = Convert.ToDouble(input);
            double metres = Math.Ceiling(km*10)*100;

            if (metres <= 500)
            {
                Console.WriteLine("Fare is $2.40");
            }
            else if (metres <= 9000 && metres > 500)
            {
                double fare = 2.40 + (((metres-500)/100)*0.04);
                Console.WriteLine("Fare is {0:c}", fare);
            }
            else if (metres > 9000)
            {
                double fare = 2.40 + (85 * 0.04) + ((metres - 9000)/100) * 0.05;
                Console.WriteLine("Fare is {0:c}", fare);
            }
            */

            /*Question 5
            Console.Write("Please enter first digit: ");
            string input1 = Console.ReadLine();
            int A = Convert.ToInt32(input1);

            Console.Write("Please enter second digit: ");
            string input2 = Console.ReadLine();
            int B = Convert.ToInt32(input2);

            Console.Write("Please enter third digit: ");
            string input3 = Console.ReadLine();
            int C = Convert.ToInt32(input3);

            int testNumber = Convert.ToInt32(input1 + input2 + input3);

            if (Math.Pow(A, 3) + Math.Pow(B, 3) + Math.Pow(C, 3) == testNumber)
            {
                Console.WriteLine("ABC is an Armstrong number.");
            }
            else
                Console.WriteLine("ABC is not an Armstrong number.");
            */

        }

    }
}
