using System;
/*EXERCISE: MATH AND COMPARISON OPERATORS
Your job is to create an anonymous income comparison program.
REQUIREMENTS
•	The program must start by printing “Anonymous Income Comparison Program” to the screen.
•	It must then print “Person 1” to the screen and get the following details:
Hourly Rate
Hours worked per week
•	It must then print “Person 2” to the screen and then get the following details:
Hourly rate
Hours worked per week
•	It must then print to the screen “Annual salary of Person 1:” and write the exact salary below it.
•	It must then print to the screen “Annual salary of Person 2:” and write the exact salary below it.
•	It must then print to the screen “Does Person 1 make more money than Person 2?” and write the true or false value of this statement below it.

EXAMPLE
Anonymous Income Comparison Program
Person 1
Hourly Rate?
15
Hours worked per week?
40
Person 2
Hourly Rate?
20
Hours worked per week?
40
Weekly salary of Person 1:
600
Weekly salary of Person 2:
800
Does Person 1 make more money than Person 2?
false
*/
namespace AnonymousIncomeComparisonProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            System.Threading.Thread.Sleep(500);
//Person1
            Console.WriteLine("Person 1");
            Console.WriteLine("Hourly Rate");
            int hrRate1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Hours worked per week");
            int hrPerWeek1 = Int32.Parse(Console.ReadLine());

//Person2
            Console.WriteLine("Person 2");
            Console.WriteLine("Hourly Rate");
            int hrRate2 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Hours worked per week");
            int hrPerWeek2 = Int32.Parse(Console.ReadLine());
            
// Calculating their Weekly salaries
            int weeksalary1 = hrRate1 * hrPerWeek1 ;
            Console.WriteLine("Weekly salary for Person 1 is " + weeksalary1);

            int weeksalary2 = hrRate2 * hrPerWeek2 ;
            Console.WriteLine("Weekly salary for Person 2 is " + weeksalary2);

// Comparison
            Console.WriteLine("Does Person 1 make more money than Person 2?");
            bool trueOrFalse = weeksalary1 > weeksalary2;
            Console.WriteLine(trueOrFalse.ToString());
            Console.ReadLine();

        }
    }
}


