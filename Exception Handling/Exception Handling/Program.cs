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

