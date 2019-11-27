using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*EXERCISE:
IN A CONSOLE APP, CREATE CODE THAT DOES THE FOLLOWING:
•	Overload the "==" operator so it checks if two Employee objects are equal by comparing their Id property.
*/
namespace Operator_Overload_2__Drill
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee();
            Employee employee2 = new Employee();

            employee1.Id = 1;
            employee1.Name = "Tasslehof";

            employee2.Id = 2;
            employee2.Name = "Raistlin";

            bool isEmployee = employee1 == employee2;

            Console.WriteLine(employee1.Name + " and " + employee2.Name + "'s employee Ids the same?: " + isEmployee);
            Console.ReadLine();
        }
    }
}
