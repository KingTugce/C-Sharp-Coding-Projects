using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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


            //int product = 5000001 * 50;
            //Console.WriteLine(product);
            //Console.ReadLine();

            //int total = 250 + 25;
            //Console.WriteLine("TwoHundredFifty plus Twentyfive = " + total.ToString());
            //Console.ReadLine();

            //int num1 = 25;
            //float num2 = 12.5f;
            //float total = num1 - num2;
            //Console.WriteLine(total);
            //Console.ReadLine();

            //bool trueOrFalse = 250 > 50;
            //Console.Write(trueOrFalse.ToString());
            //Console.ReadLine();

            //int remainder = 250 % 7;
            //Console.WriteLine(remainder);
            //Console.ReadLine();

        }
    }
}
