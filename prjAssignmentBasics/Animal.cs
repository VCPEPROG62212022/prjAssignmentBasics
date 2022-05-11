using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjAssignmentBasics
{
    abstract class Animal
    {
        // abstract method
        public abstract void makeSound();

        public void getHello()
        {
            Console.WriteLine("Hello from animal class");
        }
    }
}
