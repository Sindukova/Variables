using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            String input = null;
            String dogName = "Milo";
            int dogAge = 1;
            char firstLetter = 'H';
            Boolean? travel = null;
            double GPA = 4.0;
            decimal population = 34m;
            double? userGPA= null;



           Console.WriteLine("Good afternoon.My name is Hanna.");
           Console.WriteLine($"My dog's name is {dogName}. He is {dogAge} years old.");
           Console.WriteLine($"There  is no {firstLetter} in the end of my name. Spell my name as Hanna, not Hannah.");

           Console.WriteLine("Did you attend travel a lot before Covid-19? Yes/No");
           input=Console.ReadLine();
         if(input=="Yes")
            {
                Console.WriteLine("That is awsome! I love traveling!");
                travel = true;
            }
         else
            {
                Console.WriteLine("After all of this madness is over you should visit Italy!");
            }

            Console.WriteLine($"I wish my GPA was {GPA}. Well, I guess 3.5 is not that bad. ");
            Console.WriteLine("What is your GPA?");
            userGPA = Convert.ToDouble(Console.ReadLine());
            if (userGPA<3.0)
            {
                Console.WriteLine("You should put more work in!");
            }
            else if (userGPA>3.0 && userGPA<4.0 )
            {
                Console.WriteLine("Good job!");
            }
            else
            {
                Console.WriteLine("Perfect!");
            }

            Console.WriteLine($"The population of Ukraine is {population} million people");
        }
    }
}
