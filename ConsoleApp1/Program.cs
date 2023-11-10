using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_basics
{
    class program
    {
        static void Main(string[] args) {
            int x = 123; 
            int y = 377;
            int z = x + y; // x + y 

            int age = 500; // you are 500 years old
            double height = 1.78; // Your height. declaring it a double is used for numbers with decimals.
            bool alive = true; // You are not dead, I think.
            char symbol = '%'; // char allows only one character 
            String name = "Kunigami"; 
             
            Console.WriteLine("x and y together is " + z); // prints z to the console
            Console.WriteLine("You are " + age + " years old"); // writes to console your age
            Console.WriteLine("Your height is " + height + " meters"); // your height on the console
            Console.WriteLine("You are alive? " + alive);
            Console.WriteLine("Your symbol is " + symbol);
            Console.WriteLine("Your name is " + name);

            int b = Convert.ToInt32(height);
            Console.WriteLine(b);
            Console.ReadKey(); // no ugly text blocking you in the console
        }
    }
}