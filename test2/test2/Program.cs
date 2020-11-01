using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test2


{
    using System;
    class AccountTest
    {
        static void Main()
        {
            Account myAccount = new Account();

            Console.WriteLine($"Initial Name is: {myAccount.GetName()}");

            Console.Write("Enter the name: ");
            string theName = Console.ReadLine();
            myAccount.SetName(theName);

            Console.WriteLine($"myAccount name is: {myAccount.GetName90}");

            
        }
    }
}
