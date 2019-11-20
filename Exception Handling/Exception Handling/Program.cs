//Exceptions are when something goes wrong with our code, and from the user experience perspective we dont want to see user
//to see something went wrong in the code. Even thou it's users input.

using System;
    class Program
    {
        static void Main(string[] args)
        {

        try
        {
            Console.WriteLine("Pick a number. ");
            int numberOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Pick a second number.");
            int numberTwo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Dividing the two...");
            int numberThree = numberOne / numberTwo;
            Console.WriteLine(numberOne + "divided by " + "equals " + numberThree);
            Console.ReadLine();
        }

        //  ex is datatype format exception; whenever user put string instead of int exception ex will throw a meaningful message to the user.
        //catch(Exception ex)
        //{
        //    Console.WriteLine(ex.Message);
        //}
        //For a custom format like down below;


        catch (FormatException ex)
        {
            Console.WriteLine("Please Type a Whole Number.");
            
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Please don't divide by zero");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            Console.ReadLine();
        }

        
        }
    }

