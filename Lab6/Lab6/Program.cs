using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    class Program

    //A one-dimensional array p contains four elements.  The array access expressions to access each of the elements in p are 0, 1,2 and 3. change

    {
        static void Main(string[] args)
        {

            string[] months = new string[12];
            months[0] = "January";
            months[1] = "February";
            months[2] = "March";
            months[3] = "April";
            months[4] = "May";
            months[5] = "June";
            months[6] = "July";
            months[7] = "August";
            months[8] = "September";
            months[9] = "October";
            months[10] = "November";
            months[11] = "December";
            

            string[] seasons = new string[4];
            seasons[0] = "Spring";
            seasons[1] = "Summer";
            seasons[2] = "Fall";
            seasons[3] = "Winter";

            foreach (string s in seasons)
            {
                Console.WriteLine(s);
            }

            //question 6/8 below

            string[] names = { "Al Dente", "Anna Graham", "Earle Bird", "Ginger Rayle", "Iona Ford" };

            int i = 0;
            foreach (string name in names)
            {
                Console.WriteLine(name);

            }

            
            // question 5 & 7 below. 

            int[] rns = new int[1000];
            Random random = new Random();
            int randomNumber;
            i = 0;

            while (i < rns.Length)
            {
                randomNumber = random.Next(1, 100);
                rns[i] = randomNumber;
                if (i < names.Length)
                {
                    Console.WriteLine("{0,2}. {1}", i, names[i]);
                }
                i++;
            }

            foreach (int ra in rns)
            {
                Console.WriteLine(ra);
            }
        

        }
    }
}
