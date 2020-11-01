using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class MainClass
    {
        public static void Main (string[] args)
        {
            int result = Add(1, 8);
            if (result > 10)
            {
                Console.WriteLine("result is larger than 10!");
            }
            else
            {
                Console.WriteLine("result is smaller than or equal to 10");
            }
            Console.ReadKey ();
        }

        public static int Add(int num01, int num02)
        {
            return num01 + num02;
        }
       
    }
}
