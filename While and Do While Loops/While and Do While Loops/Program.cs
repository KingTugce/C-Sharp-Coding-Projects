using System;
/*
EXERCISE:
IN A CONSOLE APP, CREATE CODE THAT DOES THE FOLLOWING:
1. Do a boolean comparison using a while statement.
2. Do a boolean comparison using a do while statement.
*/


namespace While_and_Do_While_Loops
{
    class Program
    {
        static void Main(string[] args)
            

        //WHILE LOOP
        {
            int index = 500;
            while (index <= 525)
            {
                Console.WriteLine(index);
                index++;
            }

            Console.ReadLine();
        }
    
        //DO WHILE LOOP
        //  {
        //    int index = 530;
        //    do
        //    {
        //        Console.WriteLine(index);
        //        index++;
        //    } while (index <= 525) ;

        //        Console.ReadLine();
        //  }

        
    }
}
