using System;
using System.Text;

namespace String_Functions
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            EXERCISE:
            IN A CONSOLE APP, CREATE CODE THAT DOES THE FOLLOWING:
            Concatenate three strings.
            Convert a string to uppercase.
            Create a Stringbuilder and build a paragraph of text, one sentence at a time.
            */
            
            //string clouds = "Apricot said \" Hi Clouds\" ! \t\n Three different clouds type: \n\t \n High clouds are cirrus, cirrostratus, and cirrocumulus. \n Mid-level clouds are altostratus and altocumulus. \n Low-level clouds are cumulus congestus or towering cumulus.";

            //string fruit = "Peach";
            //fruit = "Nectarine";

            //clouds = clouds.ToUpper();


            //Console.WriteLine(clouds);
            //Console.ReadLine();

            StringBuilder sb = new StringBuilder();

            sb.Append("Apricot said \" Hi Clouds\" ! ");
            System.Threading.Thread.Sleep(500);
            sb.Append("\t\n Three different clouds type: \n\t");
            sb.Append("\n High clouds are cirrus, cirrostratus, and cirrocumulus.");
            sb.Append("\n Mid-level clouds are altostratus and altocumulus.");
            sb.Append("\n Low-level clouds are cumulus congestus or towering cumulus.");

            Console.WriteLine(sb);
            Console.ReadLine();
        }
    }
}
