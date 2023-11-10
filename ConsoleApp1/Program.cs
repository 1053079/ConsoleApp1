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
             
            Console.WriteLine("x and y together is " + z); // prints z to the console
            Console.WriteLine("You are " + age + " years old"); // writes to console your age

            Console.ReadKey(); // no ugly text blocking you in the console
        }
    }
}