using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int temp;
            temp = 90;
            if (temp >= 90)
                Console.WriteLine("This porridge is too hot.");
            if (temp < 70)
                Console.WriteLine("This porridge is too cold.");
            if (temp == 80)
                Console.WriteLine("This porridge is just right!");

            Console.ReadLine();
        }
    }
}
