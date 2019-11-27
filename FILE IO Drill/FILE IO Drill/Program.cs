using System;
using System.IO;             
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*EXERCISE:
IN A CONSOLE APP, CREATE CODE THAT DOES THE FOLLOWING:
1. Ask a user for a number.
2. Log that number to a text file.
3. Print the text file back to the user.
*/

namespace FILE_IO_Drill
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello there! Write a number so we can log it in a log file.");
            string userInput = Console.ReadLine();
            File.WriteAllText(@"C:/Users/tu2ce/Log.txt", userInput);

            string textRead = File.ReadAllText(@"C:/Users/tu2ce/log.txt");
            Console.WriteLine("\nLog.txt:\n" + textRead);
            Console.ReadLine();
        }
    }
}
