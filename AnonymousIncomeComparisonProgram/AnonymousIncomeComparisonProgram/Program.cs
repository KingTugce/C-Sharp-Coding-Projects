using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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


