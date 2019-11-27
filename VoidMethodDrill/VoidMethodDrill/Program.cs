using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoidMethodDrill
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                VoidMethod divide = new VoidMethod(); 
                Console.WriteLine("Hi there! Please enter a number :");
                int inputNum = Convert.ToInt32(Console.ReadLine());
                int result;
                divide.Operation(inputNum, out result);
                Console.WriteLine("The number entered,\"{0}\" divided by 2 is: {1}.", inputNum, result);

                Static.Intro();
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
