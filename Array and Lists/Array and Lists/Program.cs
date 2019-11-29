/*
EXERCISE:
IN A CONSOLE APP, CREATE CODE THAT DOES THE FOLLOWING:
1. Create an array of strings. Ask the user to select an index of the Array and then display the string at that index on the screen.
2. Create an array of integers. Ask the user to select an index of the Array and then display the integer at that index on the screen.
3. Add in a message that displays when the user selects an index that doesn’t exist.
4. Create a List of strings. Ask the user to select an index of the List and then display the content at that index on the screen.
 */
using System;
using System.Collections.Generic;

namespace Array_and_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number lower than 5");
            byte num = Convert.ToByte(Console.ReadLine());
            string[] weather = { "Happy", "Lucky", "Fun", "Sunny", "Smiley" };
            string tomorrow = num > 5 ?
                "The index you chose doesn't exist!" : 
                "Tomorrow will be " + weather[num];
            Console.WriteLine(tomorrow);
            Console.ReadLine();

            Console.WriteLine("Please select a number between 0 to 9.");
            byte num2 = Convert.ToByte(Console.ReadLine());
            int[] luckynum = { 133, 13, 123, 131, 313, 113, 1133, 3311, 33 };
            string lucky = num2 > 9 ? 
                "The index you chose doesn't exist!" :
                "Your lucky number is " + "" + luckynum[num2] + ".";
            Console.WriteLine(lucky);
            Console.ReadLine();

            Console.WriteLine("Select one index starting from 0 to 6.");
            byte num3 = Convert.ToByte(Console.ReadLine());
            List<string> day = new List<string>();
            day.Add("Sunday");
            day.Add("Monday");
            day.Add("Tuesday");
            day.Add("Wednesday");
            day.Add("Thursday");
            day.Add("Friday");
            day.Add("Saturday");
            string vacation = num3 > 6 ?
                "The index you chose doesn't exist!" :
                "We're going vacation on " + day[num3] + "!";
            Console.WriteLine(vacation);
            Console.ReadLine();
        }
    }
}
