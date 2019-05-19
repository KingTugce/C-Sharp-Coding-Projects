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
            Console.ReadLine();

            Console.WriteLine("Person 1");
            Console.WriteLine("Hourly Rate?");
            Console.WriteLine("15");
            Console.WriteLine("Hours worked per week?");
            Console.WriteLine("40");
            Console.WriteLine("Person 2");
            Console.WriteLine("Hourly Rate?");
            Console.WriteLine("20");
            Console.WriteLine("Hours worked per week?");
            Console.WriteLine("40");
            Console.WriteLine("Weekly Salary of Person 1");
            Console.WriteLine("600");
            Console.WriteLine("Weekly Salary of Person 2");
            Console.WriteLine("800");
            Console.WriteLine("Does Person 1 make more money than Person 2 ?");

            int Person1 = 15;
            int Person2 = 20;
            bool trueOrFalse = Person1 > Person2;
            Console.WriteLine(trueOrFalse.ToString());
            Console.ReadLine();





        }
    }
}
