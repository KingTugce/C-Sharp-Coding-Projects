using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class Dealer  //Note: Reason not inheriting from Deck.cs Class***Inheritance 'is' a relationship.Not 'has' a relationship.
                                //Another words 21 Game is a Game, but a dealer 'has' a deck.Dealer is not a type of deck.
    {
        public string Name { get; set; }
        public Deck Deck { get; set; }
        public int Balance { get; set; }

        public void Deal ( List<Card> Hand)
        {
            Hand.Add(Deck.Cards.First());
            Console.WriteLine(Deck.Cards.First().ToString() + "\n");
            Deck.Cards.RemoveAt(0); 
        }
    }
}
