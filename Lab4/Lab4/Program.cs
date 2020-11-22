using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Program

    // Question 2:
    // Counter variables - are used to keep track of the total count. this means to track how many times a piece of cose is executed.
    // initial value of the counter variable - This the starting number of the count, where the code initializes from and either subtracts or adds from.
    // increament or decreament variable - This is the manor of which the count is altered. Either addeding or submtracting from the Initialized number.
    // loop-continuation condition - This determines if the code continues. if the code results are true it continues, if the code conditions are false it terminates.
    // question 3:
    // The "while" loop is used when the number of iterations are not know and the "for" loop once done never repeats. The "for" Loop will continually increase or decrease un the condition returns false.  While Loops allow you a little more flexability in what you put in it, and when it will stop such as.
    // question 4:
    // a do while statement executes the block of code atleast once. the while states would run and continue to run until the statesment is returned false. A do while statment could save on performace as it would check is the most basic requirement is present if not it terminates there.
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Below is question 5");

            for (int i = 1; i < 100; i++)
            {
                Console.WriteLine(i);
                {
                    if ((i % 2) == 0)
                    { Console.WriteLine("Number is even"); }
                    else if ((i % 2) != 0)
                    {
                        Console.WriteLine("Number is odd");
                    }
                }
            }
            Console.WriteLine("below is question 5");

            Console.Write("Please enter a temperature: ");
            int temp = Convert.ToInt32(Console.ReadLine());

            if (temp >= 90) { Console.WriteLine("fish"); }

            else if (temp >= 80) { Console.WriteLine("Lion"); }

            else if (temp >= 70) { Console.WriteLine("Turle"); }

            else if (temp >= 60) { Console.WriteLine("Deer"); }

            else if (temp >= 50) { Console.WriteLine("Reindeer"); }

            else if (temp >= 40) { Console.WriteLine("Moose"); }

            else if (temp >= 20) { Console.WriteLine("Penguin"); }

            else if (temp >= 10) { Console.WriteLine("Polar Bear"); }

            else
            {
                Console.WriteLine("Bug");
            }

            Console.WriteLine("below is question 5");

            int i2 = 10;
            while (i2 <= 20)
            {
                Console.WriteLine(i2);
                i2++;
            }

            Console.WriteLine("below is question 6");

            for (int i3 = 0; i3 <= 100; i3++)
            {
                Console.WriteLine(i3);
                Console.WriteLine("********");
            }
        }
    }
}
