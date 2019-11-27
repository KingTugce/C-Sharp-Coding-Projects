using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drill_Abstract_Classes
{
    public abstract class Person
    {
        public string firstName { get; set; }
        public string lastName { get; set; }

        public void ID()
        {
            Console.WriteLine("Name: " + firstName + " " + lastName);
            Console.ReadLine();
        }
    }
}
