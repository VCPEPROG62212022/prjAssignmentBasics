using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjAssignmentBasics
{
    class Puppy:Dog
    {
        public void PuppyBark()
        {
            this.makeSound();
            Console.WriteLine(" Squeek Squeek");
        }
    }
}
