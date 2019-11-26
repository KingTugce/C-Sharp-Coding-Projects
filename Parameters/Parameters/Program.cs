using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
IN A CONSOLE APP, CREATE CODE THAT DOES THE FOLLOWING:
1.  Create a class. In that class, create a void method that takes two integers as parameters. 
    Have the method do a math operation on the first integer and display the second integer to the screen.
2. In the Main() method of the console app, instantiate the class.
3. Call the method in the class, passing in two numbers.
4. Call the method in the class, specifying the parameters by name.
This may seem odd, but it is for practice.
*/
namespace Parameters
{
    class Program
    {
        static void Main(string[] args)
        {
            Parameters times = new Parameters();
            times.Multiplication(25, 50);
            times.Multiplication(numA: 25, numB: 50);
        }
    }
}
