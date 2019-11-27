using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parameters_2_Drill
{
    class Program
    {
        static void Main(string[] args)
        {
            try                 // *and here we put everything into try-catch, in case User types invalid data
            {
                Method2 Add = new Method2();
                Console.WriteLine("Please enter a number greater than 0: ");
                int numA = Convert.ToInt32(Console.ReadLine());
                int numB = 0;
                Console.WriteLine("If you like to enter another number please say \"yes\" or \"no\" ");
                string answer = Console.ReadLine();
                if (answer == "yes")
                {
                    Console.WriteLine("Now, please enter your second number: ");
                    numB = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(Add.Operation(NumA: numA, NumB: numB));
                }
                else
                {
                    Console.WriteLine("Ooopsie... This is the end. ");
                }
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
}
