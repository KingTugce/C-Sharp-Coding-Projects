using System;
using System.Collections.Generic;
using System.Linq;   //=======> We need this for Lambda Methods.
using System.Text;
using System.Threading.Tasks;
/*EXERCISE
IN A CONSOLE APP, CREATE CODE THAT DOES THE FOLLOWING:
1. In the Main() method, create a list of at least 10 employees.
Each employee should have a first and last name, as well as an Id.
At least two employees should have the first name "Joe".
2. Using a foreach loop, create a new list of all employees with the first name "Joe".
3. Do the same thing again, but this time with a lambda expression.
4. Using a lambda expression, make a list of all employees with an Id number greater than 5.
*/

namespace Lambda_Drill
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee person1 = new Employee() { FirstName = "Jimmy", LastName = "Fanel", ID = 1 };
            Employee person2 = new Employee() { FirstName = "Vinny", LastName = "Carns", ID = 2 };
            Employee person3 = new Employee() { FirstName = "Seany", LastName = "Stuhl", ID = 3 };
            Employee person4 = new Employee() { FirstName = "Tugce", LastName = "Ducken", ID = 4 };
            Employee person5 = new Employee() { FirstName = "Joe", LastName = "Fahren", ID = 5 };
            Employee person6 = new Employee() { FirstName = "Jack", LastName = "Kilit", ID = 6 };
            Employee person7 = new Employee() { FirstName = "Megan", LastName = "Luna", ID = 7 };
            Employee person8 = new Employee() { FirstName = "Jessica", LastName = "Christopher", ID = 8 };
            Employee person9 = new Employee() { FirstName = "Nelly", LastName = "Fruto", ID = 9 };
            Employee person10 = new Employee() { FirstName = "Joe", LastName = "Bach", ID = 10 };
            List<Employee> employees = new List<Employee>() { person1, person2, person3, person4, person5, person6, person7, person8, person8, person10 };


            List<Person> sameName = new List<Person>();
            foreach (Person person in employees)
            {
                if (person.FirstName == "Joe")
                {
                    sameName.Add(person);
                }
            }
            //With Lambda Expression;
            List<Employee> sameName2 = employees.Where(x => x.FirstName == "Joe").ToList();
            sameName2.ForEach(x => x.PersonName());

            //With Lambda Expression;
            List<Employee> idGreaterThanFive = employees.Where(x => x.ID > 5).ToList();
            Console.ReadLine();
        }
    }
}
