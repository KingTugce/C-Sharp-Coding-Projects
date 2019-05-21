using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String
{
    class Program
    {
        static void Main(string[] args)
        {
            //string name = "Tugce";
            //string quote = "The man said, \"Hello\" , Tugce. \n Hello on a new line. \n \t Hello on a tab.";
            //string fileName = @"C:\Users\Jesse";


            //bool trueOrFalse = name.Contains("c");
            //trueOrFalse = name.EndsWith("c");

            //int length = name.Length;

            //name = name.ToUpper();



            //Console.WriteLine(trueOrFalse);
            //Console.ReadLine();

            //string name = "Tugce";
            //name = "Joe";

            StringBuilder sb = new StringBuilder();

            sb.Append("My name is Tugce");

            Console.WriteLine(sb);
            Console.ReadLine();
        }
    }
}
