using System;

namespace prjAssignmentBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dog a = new Dog();
            //a.getHello();
            //a.makeSound();
            //a.AddData("HelloWorld");
            //a.setTest("The memo to the assignment " +
            //    "is under my desk");
            //Console.WriteLine(a.getData());
            //Console.WriteLine("*************");
            //Puppy p = new Puppy();
            //p.PuppyBark();
            //Console.WriteLine( p.getData());
            //p.getTest();
            //Console.WriteLine("*************");
            //p.AddData("The puppy stole the homework");
            //Dog w = new Dog();
            //Console.WriteLine(w.getData());


            //String strName = "Dog";

            //String strValue;
            String[] strQuestions = {"Enter Dogs Age ","Enter cats Age",
                "Enter Fish's age"};
            int[] Answers = new int[3];
            int x = 0;
            Boolean bControl = false;
            while (bControl == false)
            {
                try
                {
                    Console.WriteLine(strQuestions[x]);
                    Answers [x]= int.Parse(Console.ReadLine());
                    if (Answers[x] > 0)
                    {
                        bControl = true;
                        x++;
                    }
                    
                    if (x<3)
                    {
                        bControl = false;
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine("Please try not " +
                        "do that again");
                }

            }
      

        }
    }
}
