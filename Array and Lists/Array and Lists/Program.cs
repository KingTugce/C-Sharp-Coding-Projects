/*
EXERCISE:
IN A CONSOLE APP, CREATE CODE THAT DOES THE FOLLOWING:
1. Create an array of strings. Ask the user to select an index of the Array and then display the string at that index on the screen.
2. Create an array of integers. Ask the user to select an index of the Array and then display the integer at that index on the screen.
3. Add in a message that displays when the user selects an index that doesn’t exist.
4. Create a List of strings. Ask the user to select an index of the List and then display the content at that index on the screen.
By:Tugce Simsek
 */
using System;
using System.Collections.Generic;

namespace Array_and_Lists
{
    class Program
    {
        static void Main(string[] args)
        {

            ////an array of strings

            string[] DayOfWeek = new string[6];
            DayOfWeek[0] = "Sunday";
            DayOfWeek[1] = "Monday";
            DayOfWeek[2] = "Tuesday";
            DayOfWeek[3] = "Wednesday";
            DayOfWeek[4] = "Thursday";
            
            string[]    DayOfWeek1  = new string[] {"Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
            
            Console.WriteLine("Give me a number");
            int UserInput = Convert.ToInt32(Console.ReadLine());
           
            if (UserInput > 6)
            {
                Console.WriteLine("index doesn't exist. ");
            }



            Console.ReadLine(); 

            ////an List of strings:

            //List<string> intList = new List<string>();
            //intList.Add("Hello");
            //intList.Add("There");
            //intList.Add("How");
            //intList.Add("is");
            //intList.Add("the");
            //intList.Add("Weather");
            //intList.Add("Today?");
            ////intList.Remove("There");

            //Console.WriteLine(intList[5]);
            //Console.ReadLine();


            ////an List of integers:

            //List<int> intList = new List<int>();
            //intList.Add(250);
            //intList.Add(500);
            //intList.Add(750);
            //intList.Add(1000);

            ////intList.Remove(500);

            //Console.WriteLine(intList[3]);
            //Console.ReadLine();


        }
    }
}
