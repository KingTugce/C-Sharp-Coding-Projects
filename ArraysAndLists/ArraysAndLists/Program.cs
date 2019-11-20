using System;
using System.Collections.Generic;

    class Program
    {
        
        static void Main(string[] args)
        {
        
        //N.B: using System.Collections.Generic is part of the library."LIST are created by C# 2.0. and they are very similar to Arrays.
        //But List called System.Collections.Generic; needs to be use un order to create Lists.They're
        //called 'Generics' because you can create a list with any datatype, similar to an array but in a different namespace.
        
        //N.B: ists are much more adaptable and there are a lot more methods connected to them.
        List<int> intList = new List<int>();
        intList.Add(4);
        intList.Add(10);
        //intList.Remove(10);

        Console.WriteLine(intList[0]);
        Console.ReadLine();
        /*-------------------------------WITH STRING-------------------------------*/
        List<string> intList = new List<string>();
        intList.Add("Hello");
        intList.Add("Tugce");
        //intList.Remove("Tugce");

        Console.WriteLine(intList[0]);
        Console.ReadLine();
         // N.B: W are gonna use array something small and fixed or for very large quantitie of things.

         //N.B:integer Array call numArray.
       
        //N.B:Actually create an Array,we have to instantiate it,because Arrays are C# construct called Objects.
        
        //N.B: in C#, we have to define LENGTH of it before we begin. (How long, how many items this array will hold)like DOWN BELOW:
            
           
        int[] numArray = new int[5];
        numArray[0] = 5;
        numArray[1] = 2;
        numArray[2] = 10;
        numArray[3] = 200;
        numArray[4] = 5000;
        
        //N.B: This time we are not gonna put the length but instead we put curly bracelets.There is 
        //A little bit easier,flexible nd CLEANER way to do it like down below:
          int[] numArray1 = new int[] { 5, 2, 10, 200, 5000, 600, 2300 };

        //N.B:There is even FASTER way to do that:
        int[] numArray2 = { 5, 2, 10, 200, 5000, 600, 2300 };
        
        //N.B: To change a value in an array; 
        numArray2[5] = 650;

        Console.WriteLine(numArray2[5]);
        Console.ReadLine();

    }
    }

