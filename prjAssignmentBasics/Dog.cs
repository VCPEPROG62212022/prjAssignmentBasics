using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjAssignmentBasics
{
    class Dog : Animal
    {
        private static String userData;
        private String Test;
        public override void makeSound()
        {
            Console.WriteLine("Bark Bark");
        }
        public void AddData(String strInput)
        {
            userData = strInput;
        }

        public String getData()
        {
            return userData;
        }
        public void setTest(String strInput)
        {
            this.Test = strInput;
        }
        public void getTest()
        {
            Console.WriteLine(Test);
        }

    }
}
