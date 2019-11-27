using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overloading
{
    class Method
    {
        public static int Operation(int num)
        {
            num = + 75;

            return num;
        }
        
        public static int Operation(decimal num)
        {
            num = num / 50;

            int result = Convert.ToInt32(num);
            
            return result;
        }

        public static int Operation(string num)
        {
            int result = Convert.ToInt32(num);

            result = result - 25;

            return result;
        }
    }
}
