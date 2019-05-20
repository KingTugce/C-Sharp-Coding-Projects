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
            Console.ReadLine();

            Console.WriteLine("Please enter the packageWeight: ");
            int packageWeight = Convert.ToInt32(Console.ReadLine());
         
            if (packageWeight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            }
            Console.ReadLine();

            Console.WriteLine("Please enter the packageWidth: ");
            int packageWidth = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the packageHeight: ");
            int packageHeight = Convert.ToInt32(Console.ReadLine());
 
            Console.WriteLine("Please enter the packageLength: ");
            int packageLength = Convert.ToInt32(Console.ReadLine());

            if (packageHeight + packageLength + packageWeight + packageWidth > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.")
            }

            Console.ReadLine();

           
        }
    }
}
