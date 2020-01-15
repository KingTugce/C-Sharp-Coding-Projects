using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    //Note:Design toward abstraction.That means more generic to make our code it's easier to add features to it later.
    public class Game
    {
        public List<string> Players { get; set; }
        public string Name { get; set; }
        public string Dealer { get; set; }

        public void ListPlayers()
        {
            foreach(string player in Players)
            {
                Console.WriteLine(player);
            }

        }
    }
}
