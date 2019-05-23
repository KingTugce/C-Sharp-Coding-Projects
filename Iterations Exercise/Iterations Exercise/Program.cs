using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterations_Exercise
{
    class Program
    {

        static void Main(string[] args)
        {
           //List<string> Clouds = new List<string>();
           // Clouds[0] = "Cumulus humilis";
           // Clouds[1] = "Cumulus mediocris";
           // Clouds[2] = "Cumulonimbus";
           // Clouds[3] = "Sirrus";
           // Clouds[4] = "Sirrostratus";



            string[] Clouds = { "Cumulus humilis ", "Cumulus mediocris ", "Cumulonimbus ", "Sirrus ", "Sirrostratus " };

            Console.WriteLine("What is your favorite cloud type?:\n");
            string favcloud = Console.ReadLine();

             for (int i = 0; i < Clouds.Length; i++)
                {
                     Clouds[i] = Clouds[i] + favcloud;

                     Console.WriteLine(Clouds[i]);
                }
            Console.ReadLine();

        }

    }
}
