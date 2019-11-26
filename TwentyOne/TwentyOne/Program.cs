﻿using System;
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
            Deck deck = new Deck();
            //int timesShuffled = 0;
            //deck = Shuffle(deck,out timesShuffled, 3);       //======> if comment only this line out it would be perfectly in order.
            deck.Shuffle(3);                                                 
      

            foreach ( Card card in deck.Cards) 
            {
                Console.WriteLine(card.Face + " of " + card.Suit );
            }
            Console.WriteLine(deck.Cards.Count);
            //Console.WriteLine("Times shuffled: {0}", timesShuffled);
            Console.ReadLine();
            
            
            //deck.Cards = new List<Card>();

            ////N.B :let's create a deck of card:

            //Card cardOne = new Card();                                     //N.B : This will print "Quenn of Spades".
            //cardOne.Face = "Quenn";                                        //N.B : If we dont assign any values later those are the default values.
            //cardOne.Suit = "Spades";

            //deck.Cards.Add(cardOne); 
            ////N.B : Filling this deck one by one will take too much time, thats why we will use the "constructor".The card class may not need constuctor 
            ////N.B : but deck class could curtenlly needs one.
            
            //Console.WriteLine(deck.Cards[0].Face + " of " + deck.Cards[0].Suit);
            //Console.ReadLine();
        }
        //public static Deck Shuffle(Deck deck, out int timesShuffled, int times = 1)
        //{

        //    timesShuffled = 0;
        //    for(int i = 0; i < times; i++)                                         //=========> Optional Paramaters 
        //    {
        //        timesShuffled = 0;
        //        List<Card> TempList = new List<Card>();
        //        Random random = new Random();

        //        while (deck.Cards.Count > 0)
        //        {
        //            int randomIndex = random.Next(0, deck.Cards.Count);
        //            TempList.Add(deck.Cards[randomIndex]);
        //            deck.Cards.RemoveAt(randomIndex);
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