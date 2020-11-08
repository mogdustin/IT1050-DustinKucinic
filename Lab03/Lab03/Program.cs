using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03
{
    class Program
    {
        // Both If an While check if the statement is true or fasle. the major difference is the "If" statement will execute the next line and stop. The "While" Statement will continue to execute the code for however long the statement is true.

        static void Main(string[] args)
        {
            //Question 3 below:

            Console.WriteLine("Question 3 below");

            int speedLimit;
            int speed;
            speedLimit = 35;
            speed = 42;

            if (speed > speedLimit) ;
            {
                Console.WriteLine("SLOW NOW!");
            }

            // Question 4 below:

            Console.WriteLine("Question 4 below");

            bool isFalse = 5 > 6;
            Console.WriteLine("It is {0}", isFalse);

            bool isTrue = 5 < 6;
            Console.WriteLine("It is {0}", isTrue);

            // Question 5 below:

            Console.WriteLine("Question 5 below");

            Console.WriteLine(" Enter Fahrenheit temperature you want converted");
            double fahrenheit = Convert.ToDouble(Console.ReadLine());
            double celsius = (fahrenheit - 32d) * 5d / 9d;
            {
                Console.WriteLine(celsius);
            }
            if (fahrenheit < 40)
            {
                Console.WriteLine(" It is Cold");
            }
            else if (fahrenheit > 40)
            {
                Console.WriteLine("It is Hot");
            }

            // Question 6 below

            Console.WriteLine("Question 6 below");

            int index = 1;
            while (index <= 10)
            {
                Console.WriteLine(index);
                index += 1;

            }

            // Question 7 below

            Console.WriteLine("Question 7 below");

            int index2 = 60;
            while (index2 >= 20)
            {
                Console.WriteLine(index2);
                index2 -= 5;
            }

            // Question 8 below

            Console.WriteLine("Question 8 below");

            int index3 = 10;
            while (index3 <= 20)
            {
                Console.WriteLine(index3);
                index3 += 2;
            }

        }


    }
}
