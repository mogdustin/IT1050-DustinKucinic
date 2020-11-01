using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02
{
    public class Multiplication
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!\nfrom Dustin Kucinic");
            //from the main method.
            //a integer is a non-decimal numeric number, While a floating point is one with a decimal.
            //Name = accountName 
            //get accessor/set accessor
            //A class is used to house a method while an object is and instance of the class. You can create as many instances of a class as you need as long as each one has a different object.

            int num1;
            int num2;
            int sum;

            Console.Write("input the first number to Multiply: ");
            num1 = Convert.ToInt32(Console.ReadLine() );

            Console.Write("input the first number to Multiply: ");
            num2 = Convert.ToInt32(Console.ReadLine() );

            sum = num1 * num2;

            Console.WriteLine("Sum is: {0}", sum );

        }
    }
}
            
   
