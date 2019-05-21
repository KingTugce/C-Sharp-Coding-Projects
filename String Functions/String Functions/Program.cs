using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Functions
{
    class Program
    {
        static void Main(string[] args)
        {
            
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
