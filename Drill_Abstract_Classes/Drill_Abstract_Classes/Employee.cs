using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drill_Abstract_Classes
{
    class Employee : Person
    {
        public void ID()
        {
            Console.WriteLine("Name is: " + firstName + " " + lastName);
            Console.ReadLine();
        }
    }
}
