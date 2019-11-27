using OperatorOverloading;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
EXERCISE:
IN A CONSOLE APP, CREATE CODE THAT DOES THE FOLLOWING:
1. Create a class. In that class, create a method that will take in an integer, do a math operation to it and then return the answer as an integer.
2. In the Main() method of the console app, instantiate the class and call the one method, passing in an integer, such as 12. Then display the result to the screen.
3. Add a second method to the class, with the same name, that will take in a decimal, do a different math operation to it and then return the answer as an integer.
4. In the Main() method of the console app, instantiate the class and call the second method, passing in a decimal. Display the result to the screen.
5. Add a third method to the class, with the same name, that will take in a string, convert it to an integer if possible, do a different math operation to it and then return the answer as an integer.
6. In the Main() method of the console app, instantiate the class and call the third method, passing in a string that equates to an integer.Display the result to the screen.
*/

namespace OperatorOverloadingDrill
{
    class Program
    {
        static void Main(string[] args)
        {
            int add = Method.Operation(12);
            Console.WriteLine("Added to 75: {0}", add);
            Console.ReadLine();

            int divide = Method.Operation(12.3m);
            Console.WriteLine("Divide by 50: {0}", divide);
            Console.ReadLine();

            int substract = Method.Operation("19");
            Console.WriteLine("Substracted by 25: {0}", substract);
            Console.ReadLine();
        }

    }
}
