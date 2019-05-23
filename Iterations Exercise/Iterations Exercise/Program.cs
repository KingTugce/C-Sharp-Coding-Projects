using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterations_Exercise
{
    class Program
    {
       

        static void Main(string[] args)
        {

            //1. Create a one - dimensional Array of strings.Ask the user to input some text.
            //Create a loop that goes through each string in the Array, 
            //adding the user’s text to the string.
            //Then create a loop that prints off each string in the Array on a separate line.

            //string[] Clouds = { "Cumulus humilis ", "Cumulus mediocris ", "Cumulonimbus ", "Cirrus ", "Cirrostratus " };

            //Console.WriteLine("What is your favorite cloud type?:\n");
            //string favcloud = Console.ReadLine();

            // for (int i = 0; i < Clouds.Length; i++)
            //    {
            //         Clouds[i] = Clouds[i] + favcloud;
            //         Console.WriteLine(Clouds[i]);
            //    }

            //Console.ReadLine();


            //2. Create an infinite Loop


            //bool Infinite = false;

            //while (!Infinite)
            //{
            //    Console.WriteLine("Infinite!");
            //}
            //Console.ReadLine();


            //===========================================================================================================//


            //3. Fix the infinite loop so it will execute.

            //bool StopInfinite = false;

            //while (!StopInfinite)
            //{
            //    Console.WriteLine("Infinite Over");
            //    StopInfinite = true;
            //}
            //Console.ReadLine();


            //===============================================================================================================//


            //4. Create a loop where the comparison used to determine whether to continue iterating the loop is a “<” operator.//

            //for (int c = 0; c < Clouds.Length - 1; c++)
            //{
            //    Console.WriteLine(Clouds[c]);
            //}
            //Console.ReadLine();

            //5.Create a loop where the comparison used to determine whether to continue iterating the loop

            //for (int c = 0; c <= Clouds.Length - 1; c++)
            //{
            //    Console.WriteLine(Clouds[c]);
            //}
            //Console.ReadLine();

            //6.Create a List of strings where each item in the list is unique.Ask the user to select text to 
            //search for in the List.Create a loop that iterates through the list and then displays the index of 
            //the array that contains matching text on the screen.

            //7.Add code to that above loop that tells a user if they put in text that isn’t in the List.

            //8.Add code to that above loop that stops it from executing once a match has been found.

            //9.Create a List of strings that has at least two identical strings in the List. 
            //Ask the user to select text to search for in the List.
            //Create a loop that iterates through the list and then displays the indices of the array that contain matching text on the screen.

            //10.Add code to that above loop that tells a user if they put in text that isn’t in the List.

            //List<string> Clouds = new List<string>() { "sheets", "at", "different", "layers", "of", "the", "upper", "troposphere",
            //                                           "which", "may be", "connected at", "one or more", "points",
            //                                            "normally", "associated with", "fibratus","and", "uncinus", "species",
            //                                            "Cumulus humilis ", "Cumulus mediocris ", "Cumulonimbus ", "Cirrus ", "Cirrostratus ",
            //                                            "Cirrus fibratus","Cirrus uncinus" , "Cirrus spissatus" , "Cirrus castellanus",
            //                                            "Cirrus altocumulogenitus" , "Cirrus homogenitus","Cirrus cirrocumulogenitus" };

            //Console.WriteLine("Select a Cloud from the List: ");
            //string userInput = Console.ReadLine().ToLower();
            //bool match = false;
            //while (!match)
            //{
            //    for (int c = 0; c < Clouds.Count; c++)
            //    {
            //        if (Clouds[c] == userInput)
            //        {
            //            Console.WriteLine(c);
            //            match = true;
            //        }
            //    }
            //    if(!match)
            //    {
            //        Console.WriteLine("Oops...No Match! Please Try Again: ");
            //        userInput = Console.ReadLine().ToLower();
            //    }
            //}

            //Console.ReadLine();

            List<string> TextClouds = new List<string>() { 
                                                          "which", "may be", "connected at", "one or more", "points",
                                                          "normally", "associated with", "fibratus","and", "uncinus", "species",
                                                          "Cumulus humilis ", "Cumulus mediocris ", "Cumulonimbus ", "Cirrus ", "Cirrostratus ",
                                                          "Cirrus fibratus","Cirrus uncinus" , "Cirrus spissatus" , "Cirrus castellanus",
                                                          "Cirrusaltocumulogenitus" , "Cirrushomogenitus","Cirruscirrocumulogenitus" };
            List<string> TextClouds1 = new List<string>();
            foreach (string text in TextClouds)
            {
                for (int t = 0; t < TextClouds1.Count; t++)
                {
                    if (text == TextClouds1[t])
                    {
                        Console.WriteLine("This word already appeared:");
                    }
                }
                TextClouds1.Add(text);
                Console.WriteLine(text);
            }

            Console.ReadLine();





        }

    }
}
