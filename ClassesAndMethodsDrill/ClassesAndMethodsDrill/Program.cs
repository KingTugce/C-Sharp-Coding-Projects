using System;

/*EXERCISE:
IN A CONSOLE APP, CREATE CODE THAT DOES THE FOLLOWING:
1. Create a class. In that class, create three methods, each of which will take one integer parameter in and return an integer.
The methods should do some math operation on the received parameter.Put this class in a separate.cs file in the application.
2. In the Main() program, ask the user what number they want to do the math operations on.
3. Call each method in turn, passing the user input to the method.Display the returned integer to the screen.*/

namespace ClassesAndMethodsDrill
{
    class Program
    {
       
        static void Main(string[] args)
        {
            Console.WriteLine("Please type a number that we can :");
            Console.WriteLine("1.   Add 75 ");
            Console.WriteLine("2.   Divide to 50 ");
            Console.WriteLine("3.   Multiply to 25 ");
            int userNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Your number plus 75 is : " + ThreeMethods.Add75(userNum));
            Console.WriteLine("Your number divide by 50 : " + ThreeMethods.Divide50(userNum));
            Console.WriteLine("Your number multiplied to 25 is : " + ThreeMethods.Times25(userNum));

            Console.ReadLine();

        }
       
        
    }
}
