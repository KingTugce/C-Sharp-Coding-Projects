using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*EXERCISE:
IN A CONSOLE APP, CREATE CODE THAT DOES THE FOLLOWING:
1. Make the Employee class take a generic type parameter.
2. Add a property to the Employee class called "things" and have its data type be a generic list matching the generic type of the class.
3. Instantiate an Employee object with type "string" as its generic parameter.Assign a list of strings as the property value of Things.
4. Instantiate an Employee object with type "int" as its generic parameter.Assign a list of integers as the property value of Things.
5. Create a loop that prints all of the Things to the Console.
*/

namespace Generics_Drill
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Employee<string> vehicles = new Employee<string>();

            vehicles.Things = new List<string>();

            vehicles.Things.Add("Bicycle");
            vehicles.Things.Add("Car");
            vehicles.Things.Add("Scooter");
           
            
            Employee<int> parkinglot = new Employee<int>();
            parkinglot.Things = new List<int>();
            parkinglot.Things.Add(1);
            parkinglot.Things.Add(2);
            parkinglot.Things.Add(3);

            Console.WriteLine("These are the employee's Vehicles:");
            foreach (string thing in vehicles.Things)
            {
                Console.WriteLine(thing);
            }
            Console.WriteLine("\nAnd these are parking space for the employee's Vehicles:");
            foreach (int thing in parkinglot.Things)
            {
                Console.WriteLine(thing);
            }
            Console.ReadLine();
        }
    }
}
