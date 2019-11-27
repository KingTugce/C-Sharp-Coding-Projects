using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*EXERCISE:
1. Create a const variable
2. Create a variable using the keyword "var".
3. Chain two constructors together.
*/
namespace Const_Variable_Drill
{
    class Program
    {
        static void Main(string[] args)
        {
            
            

            Console.WriteLine("Hi There! May l ask your name?");
            string name = Console.ReadLine();

            Console.WriteLine("What is your favorite food? (Feel free to not answer)");
            string food = Console.ReadLine();

            const int num = 100;

            if (string.IsNullOrEmpty(food))
            {
                //N.B : Here is the creation of a variable using 'var'.
                var person = new Person(name);
                person.FavFood();
            }
            else
            {
                var person = new Person(name, food);
                person.FavFood();
            }

            Console.ReadLine();
        }
    }
    public class Person
    {
        //N.B : Here are constructors chain:
        public Person(string name) : this(name, "N/A") { }
        public Person(string name, string food)
        {
            Name = name;
            Food = food;
        }

        public void FavFood()
        {
            Console.WriteLine("\nHello {0}, Your favorite food is {1}.", Name, Food);
        }

        public string Name { get; set; }
        public string Food { get; set; }
    }
}

    