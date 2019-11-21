using System;
/*
EXERCISE: BRANCHING
Your job is to create a console-based application for getting a shipping quote for a package.
REQUIREMENTS
The first line of the program must be: “Welcome to Package Express. Please follow the instructions below.”
The user must then be prompted for the package weight.
If the weight is greater than 50, display the error message, “Package too heavy to be shipped via Package Express. Have a good day.” 
At this point the program would end.
The user must then be prompted for the package width.
Then the package height.
Then the package length.
If the sum of the dimensions is greater than 50, display the error message, “Package too big to be shipped via Package Express.” 
At this point the program would end.
The sum total of dimensions are then multiplied by the weight and divided by 100.
The result of that calculation is the quote.
Display the quote to the user as a dollar amount.
EXAMPLE
Welcome to Package Express. Please follow the instructions below.
Please enter the package weight:
40
Please enter the package width:
5
Please enter the package height:
 3
Please enter the package length:
 3
Your estimated total for shipping this package is: $4.40
Thank you.
*/


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
