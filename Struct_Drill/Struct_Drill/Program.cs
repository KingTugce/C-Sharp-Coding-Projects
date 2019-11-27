using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*EXERCISE:
IN A CONSOLE APP, CREATE CODE THAT DOES THE FOLLOWING:
1. Create a struct called Number and give it the property "Amount" and have it be of data type decimal.
2. In the Main() method, create an object of data type Number and assign an amount to it.
3. Print this amount to the console.
*/
namespace Struct_Drill
{
    class Program
    {
        static void Main(string[] args)
        {
            
                Number num = new Number();
                num.Amount = 115.50m;
                Console.WriteLine(num.Amount);
                Console.ReadLine();
            
        }

        struct Number
        {
            public decimal Amount { get; set; }
        }
    }

}
