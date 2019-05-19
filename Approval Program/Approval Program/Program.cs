using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Approval_Program
{
    class Program
    {
    

        static void Main(string[] args)
        {


            //            REQUIREMENTS

            //Ask the following questions:

            //            What is your age ?

            //            Have you ever had a DUI?

            //How many speeding tickets do you have?

            //Use the following qualification rules to determine if the applicant qualifies for car insurance:

            //Applicants must be over 15 years old.

            //Applicants must not have any DUI’s.

            //Applicants must not have more than 3 speeding tickets.

            //Print the result of the boolean expression created from the above business rules.

            Console.WriteLine("What is your age?");
            Console.WriteLine(30);
            Console.WriteLine("Have you ever had a DUI?");
            Console.WriteLine("false");
            Console.WriteLine(" How many speeding tickets do you have?");
            Console.WriteLine(1);
            

            int AppAge = 30;
            string AppDUI = "0";
            int SpeedingTickets = 1;
            bool isQualified = (AppAge > 15 && AppDUI == "0" && SpeedingTickets < 3);

            Console.WriteLine(isQualified);

            Console.ReadLine();


        }
    }
}
