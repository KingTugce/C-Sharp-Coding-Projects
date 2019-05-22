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
            
            Console.WriteLine(DayOfWeek1[3]);
            Console.ReadLine();

            ////"3.Add in a message that displays when the user selects an index that doesn’t exist." l didn't understand how to add in a message.
            //if (DayOfWeek.Length > 6)

            //{
            //    Console.WriteLine("index doesn't exist. ");
            //}




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
