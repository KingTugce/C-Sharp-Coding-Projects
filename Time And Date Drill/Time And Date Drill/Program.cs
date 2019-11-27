using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
EXERCISE:
IN A CONSOLE APP, CREATE CODE THAT DOES THE FOLLOWING:
1. Prints the current date and time to the console.
2. Asks the user for a number.
3. Prints to the console the exact time it will be in X hours, X being the number the user entered in step 2.
*/
namespace Time_And_Date_Drill
{
    class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine(DateTime.Now);
            
            Console.Write("Hi there, Please Enter a number and let me show you what time will be in the future from now: ");
            Double userInput = Convert.ToDouble(Console.ReadLine());

            DateTime dateTime = new DateTime();
            dateTime = DateTime.Now;
            Console.WriteLine(dateTime.AddHours(userInput));
            Console.ReadLine();
        }
    }
}
