using System;

namespace CarInsuranceApprovalProgramDrill_6
{
    class Program
    {
    

        static void Main(string[] args)
        {

            /*         REQUIRMENTS

            ask the following questions:

            What is your age ?
            
            Have you ever had a DUI?

            How many speeding tickets do you have?

            Use the following qualification rules to determine if the applicant qualifies for car insurance:

            Applicants must be over 15 years old.

            Applicants must not have any DUI’s.

            Applicants must not have more than 3 speeding tickets.

            Print the result of the boolean expression created from the above business rules.


            EXAMPLE OUTPUT

            Console.WriteLine("What is your age?");
            Console.WriteLine(30);
            Console.WriteLine("Have you ever had a DUI?");
            Console.WriteLine("false");
            Console.WriteLine(" How many speeding tickets do you have?");
            Console.WriteLine(1);

            */

            Console.WriteLine("What is your age?");
            int userAge = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Have you ever had a DUI? Please say 'true' or 'false')");
            bool userDUI = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("How many tickets do you have?");
            int userSpeedingTickets = Convert.ToInt32(Console.ReadLine());

            bool isQualified = (userAge > 15 && userDUI == false && userSpeedingTickets <= 3);

            Console.WriteLine("Are you Qualified?");
            Console.WriteLine(isQualified);


            Console.ReadLine();

            int AppAge = 30;
            string AppDUI = "0";
            int SpeedingTickets = 1;
            bool Qualified = (AppAge > 15 && AppDUI == "0" && SpeedingTickets < 3);

            Console.WriteLine(isQualified);

            Console.ReadLine();


        }
    }
}
