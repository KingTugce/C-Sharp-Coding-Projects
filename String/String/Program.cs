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
            //N.B: '\n' is a new line and '\t' used for a tab. scape character is '\' . 
            string name = "Tugce";
            string quote = "The man said, \"Hello\" , Tugce. \n Hello on a new line. \n \t Hello on a tab.";
            
            //N.B: @ = \\
            string fileName = @"C:\Users\Jesse";
     
            //N.B: You can use different built in functions (for strings) which can help you determine different things happening in a string.
            bool trueOrFalse = name.Contains("c"); //NOTE: This will equal to 'true'.
            trueOrFalse = name.EndsWith("c"); //NOTE: This will equal to 'false'.
            
            //Console.WriteLine(trueOrFalse);
            //Console.ReadLine();

            //N.B: Gets the character length.
            int length = name.Length;
            
            //N.B: Other built in functions one can use are 'ToUpper' for upper casing all and 'ToLower' lower casing all.
              Name = name.ToUpper();
              Name = name.ToLower();
            //Console.WriteLine(Name);
            //Console.ReadLine();

            //N.B: Strings are immuatable that means; you can't change them in C#.
            string name = "Tugce";
            //N.B: whenever we assign a different value of string,it will look like we changed it but 
            //what actually happens is in this ,create a new string of memory 
            //with the value of 'joe' like down below:    
            name = "Joe";
            //Console.Writeline(name);
            //Console.Readline();

            //N.B: 'using System.Text;' must to stay in order to use stringbuilder.
            StringBuilder sb = new StringBuilder();
            
            sb.Append("My name is Tugce");

            Console.WriteLine(sb);
            Console.ReadLine();
        }
    }
}
