using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shipping_Quote_For_a_Package
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            System.Threading.Thread.Sleep(1000);

            Console.WriteLine("Please enter the packageWeight: ");
            int packageWeight = int.Parse(Console.ReadLine());
         
            if (packageWeight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            }
            Console.ReadLine();

            Console.WriteLine("Please enter the packageWidth: ");
            int packageWidth = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the packageHeight: ");
            int packageHeight = int.Parse(Console.ReadLine());
 
            Console.WriteLine("Please enter the packageLength: ");
            int packageLength = int.Parse(Console.ReadLine());

            int packageDimension = packageLength + (2 * packageWidth) + (2 * packageHeight);

            if (packageDimension > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
            }
           
            else 
            {
                float packageQuote = packageDimension * packageWeight / 100;
                Console.WriteLine("Your estimated total for shipping this package is: " + "$" + packageQuote) ;
            }

            Console.ReadLine();
        }
    }
}
