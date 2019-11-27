using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*EXERCISE:
IN A CONSOLE APP, CREATE CODE THAT DOES THE FOLLOWING:
1. Create an enum for the days of the week.
2. Prompt the user to enter the current day of the week.
3. Assign the value to a variable of that enum data type you just created.
4. Wrap the above statement in a try/catch block and have it print "Please enter an actual day of the week." to the console if an error occurs.
Note - In the last video, we explained the underlying concepts behinds enums.Nobody knows everything about a programming language and its features, so it's our job as programmers to do research on how to work with various data types, classes and libraries. For this drill, you'll need to do some additional research on how to parse enums.
*/
namespace Enums_Drill
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Hi there! Please enter current day:");
                string userInput = Console.ReadLine();

                DaysOfTheWeek day = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), userInput);

                for (int i = 0; i < 7; i++)
                {
                    if (day == (DaysOfTheWeek)i)
                    {
                        Console.WriteLine("Yes! Today is {day}");
                    }
                }
            }
            

            catch (Exception ex)
            {
                Console.WriteLine("Please enter an actual day of the week." + ex.Message);
            }

            finally
            {
                Console.ReadLine();
            }
        }
        public enum DaysOfTheWeek
        {
            monday, tuesday, wednesday, thursday, friday, saturday, sunday
        }
    }
}
