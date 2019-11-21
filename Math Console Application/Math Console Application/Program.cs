using System;
/*
EXERCISE:
CREATE A CONSOLE APPLICATION THAT DOES THE FOLLOWING:
1. Takes an input from the user, multiplies it by 50, and prints the result to the console. 
(Note: make sure your code can take inputs larger than 10,000,000).
2. Takes an input from the user, adds 25 to it, and prints the result to the console.
3. Takes an input from the user, divides it by 12.5, and prints the result to the console.
4. Takes an input from the user, checks if it is greater than 50, and prints the true/false result to the console.
5. Takes an input from the user, divides it by 7, and prints the remainder to the console (tip: think % operator).
*/

namespace MathAndComparisonOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any number you want to be multiplied by 50. ");
            double userInput1 = Double.Parse(Console.ReadLine());
            double product1 = userInput1 * 50;
            Console.WriteLine("The answer is " + product1);
            System.Threading.Thread.Sleep(900);

            Console.WriteLine("Enter any number you want to be added by 25. ");
            double userInput2 = Double.Parse(Console.ReadLine());
            double product2 = userInput2 + 25;
            Console.WriteLine("The answer is " + product2);
            System.Threading.Thread.Sleep(900);

            Console.WriteLine("Enter any number you want to be divided by 12.5. ");
            double userInput3 = Double.Parse(Console.ReadLine());
            double product3 = userInput3 / 12.5;
            Console.WriteLine("The answer is " + product3);
            System.Threading.Thread.Sleep(900);

            Console.WriteLine("Enter any number you want to be greater than 50. ");
            double userInput4 = Double.Parse(Console.ReadLine());
            bool trueOrFalse = userInput4 > 50;
            Console.WriteLine("The answer is " + trueOrFalse.ToString());
            System.Threading.Thread.Sleep(900);

            Console.WriteLine("Enter any number you want to be divided it by 7, and printed the remainder. ");
            double userInput5 = Double.Parse(Console.ReadLine());
            double remainder = userInput5 % 7;
            Console.WriteLine("The answer is " + remainder);
            System.Threading.Thread.Sleep(900);

        }
    }
}
