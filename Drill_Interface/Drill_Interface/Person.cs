using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drill_Interface
{
    public abstract class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public void ID()
        {
            Console.WriteLine("Name is : {0} {1}" + FirstName + " " + LastName);
            Console.ReadLine();
        }

    }
}
