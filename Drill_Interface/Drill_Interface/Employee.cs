using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drill_Interface
{
    class Employee : Person, IQuittable
    {
        public void ID()
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName);
            Console.ReadLine();
        }

        public void Quit()
        {
            Console.WriteLine("Employee resigned: ");
            ID();
            Console.ReadLine();
        }


    }
}
