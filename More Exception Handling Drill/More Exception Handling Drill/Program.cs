using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*EXERCISE:
IN A CONSOLE APP, CREATE CODE THAT DOES THE FOLLOWING:
1. Ask the user for his age.
2. Display the year user born.
3. Exceptions must be handled using "try .. catch".
4. Display appropriate error messages if user enters zero or negative numbers.
5. Display a general message if exception caused by anything else.
*/

namespace More_Exception_Handling_Drill
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                
                Console.WriteLine(" How old are you?");
                var age = Convert.ToInt32(Console.ReadLine());

                if (age < 1)
                {
                    Console.WriteLine("Please enter your real age.");
                    return;
                }

                var currentYear = DateTime.Now;
                Console.WriteLine($"Birth year: {currentYear.Year - age}");

            }
            
            catch (Exception ex)
            {
                Console.WriteLine("Error!" + ex.Message);
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}
