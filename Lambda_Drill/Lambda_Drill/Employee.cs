using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_Drill
{
    public class Employee : Person
    {
        public override void PersonName()
        {
            Console.WriteLine("Name: {0} {1}", FirstName, LastName);
        }
    }
}
