using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testing
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(getArea(2, 3, 600));
            Console.ReadLine();
        }

        public static double getArea(double height, double width, double depth)
        {
            double area;
            area = height * width * depth;
            return area;

        }
    }
}
