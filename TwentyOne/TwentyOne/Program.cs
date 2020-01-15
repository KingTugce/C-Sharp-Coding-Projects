using System;
using System.Collections.Generic;
using System.Linq;  
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            //Super class method: when we calling a method  from a class inheriting from  we are callin the super class method.                                                                     
            //TwentyOneGame game = new TwentyOneGame();                                   
            //game.Players = new List<string>() { "Sean", "Vinny", "Jimmy" };
            //game.ListPlayers();
            //game.Play();
            //Console.ReadLine();


            //Note: Polymorhism is the ability of the class to morph into its inheriting class and it gave certain advantages.
            //TwentyOneGame can morph into the Game Object. This is classic polymorphism:

            Game game = new TwentyOneGame();

            Deck deck = new Deck();
            deck.Shuffle(3);


            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }
            Console.WriteLine(deck.Cards.Count);
            Console.ReadLine();





            //*************************************************SHUFFLED and some Methods****************************************************************



            //deck.Cards = new List<Card>();

            ////N.B :let's create a deck of card.
            //Note: We instantiated card object.

            //Card cardOne = new Card();                                //We assigned the string "Quenn" to the property 'Face' to the Object "CardOne".
            //cardOne.Face = "Quenn";                                      
            //cardOne.Suit = "Spades";

            //deck.Cards.Add(cardOne); 
            //N.B : Filling this deck one by one will take too much time, thats why we will use the "constructor".The card class may not need constuctor 
            // but deck class could certainly needs one.

            //Console.WriteLine(deck.Cards[0].Face + " of " + deck.Cards[0].Suit);
            //Console.ReadLine();
        }
        //public static Deck Shuffle(Deck deck, out int timesShuffled, int times = 1)   //=====Verifing how many times shuffled with an out paramater.
        //{

        //    timesShuffled = 0;
        //    for(int i = 0; i < times; i++)                                         //=========> *******Optional Paramaters 
        //    {
        //        timesShuffled = 0;
        //        List<Card> TempList = new List<Card>();
        //        Random random = new Random();

        //        while (deck.Cards.Count > 0)
        //        {
        //            int randomIndex = random.Next(0, deck.Cards.Count);
        //            TempList.Add(deck.Cards[randomIndex]);
        //            deck.Cards.RemoveAt(randomIndex);                                  //'RemoveAt' is function of the List Method.
        //        }
        //        deck.Cards = TempList;
        //    }

        //    return deck;

        //}
        //public static Deck Shuffle(Deck deck, int times )                        //========> Overload Parameters
        //{
        //    for (int i = 0; i < times; i++)
        //    {
        //        deck = Shuffle(deck);
        //    }
        //    return deck;
        //}
    }
}
