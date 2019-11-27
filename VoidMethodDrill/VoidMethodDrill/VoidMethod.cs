using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
EXERCISE:
IN A CONSOLE APP, CREATE CODE THAT DOES THE FOLLOWING:
1. Create a class. In that class, create a void method that outputs an integer. Have the method divide the data passed to it by 2.
2. In the Main() method, instantiate that class.
3. Have the user enter a number. Call the method on that number. Display the output to the screen. It should be the entered number, divided by two.
4. Create a method with output parameters.
5. Overload a method.
6. Declare a class to be static.
*/
namespace VoidMethodDrill
{
    class VoidMethod
    {
        public void Operation(int num)
        {
            int result = (num = num / 2);
            Console.WriteLine(result);
        }

        public void Operation(int num, out int result)
        {
            result = num / 2;
        }
    }
}
