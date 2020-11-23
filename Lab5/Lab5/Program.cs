using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class Program
    {
        //question 2:
        // public double getArea(double height, double width)
        // {
        //      return height * width;
        // }

        //Scope - The scope is public. This means where the method can be accessed inside of the code. This can be public, private or protected.
        //Static vs.Non-Static - this one be non static since we are not since we are not using a class to processes this code. If we used a Math.Sqft then we couse use the static option in the method. 
        //Return Type - the return type is double. 
        //Method Name(Identifier) - Name of the method is getArea.
        //Parameters - The are objects in the "()" that are comma seperated. 
        //Method Body - This is the items inbetween teh curly braces below the method. This is a area we will uses to add variables to set the parameters for the method.

        //question 3:
        // When you use a user define method, you have to create instance (or object) of the math class. When using a framework provided one we do not need to define the method or create a instance of it since it is already defined within the framwork.

        //question 4:
        //The static methods can by accessed directly from the class, while non-static methods (or instance methods as I like to call them) have to be accessed from an instance.


        public static void Main(string[] args)
        {
            Dog myDog = new Dog();
            myDog.Name = "Fido";
            myDog.Bark = "yes";
            myDog.DoTrick = "The Iron Lotus";

            Console.WriteLine("{0} is so smart!  {0} is doing {1}", myDog.Name, myDog.DoTrick);

            // To do: uncomment the following lines of code to call the methods
            // myDog.bark();
            // myDog.doTrick("Fetch");
        }
    
    }
}
