using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;   
using System.Threading.Tasks;

//N.B: Classes and Objects
//N.B: Objects are the backbone of the Object Oriented Programming. *Objects are items that can be represented by a computer programm.
//There often meant to represent real world thing my cat, tv etc.
//Objects have State and Behaviour. The State of an Object would be the size,color etc. any point of time.

namespace TwentyOne
{
    //Note:Card class has a property of data type string call "Suit" and "Face".Making this property "public" that means it accesible to other part of the program.
    //Class is an only design for an Object.
   public class Card
    {
        
        public Card()                 //=========> //N.B: what we create is a constructor.It is very common in programming languages in general.
                                                                //N.B: it values assign to an Object upon creation. 
        {
            Suit = "Spades";
            Face = "Two";                                       //N.B: The Constracter Method name is technically a function, always the name of the class.Thats how C# knows this is a constructur.
                                                                //N.B: If we comment it out the values in the Program.cs it will print inside the public Card and that will print
                                                                // "Two of Spades"
        }
        public string Suit { get; set; }
        public string Face { get; set; }
    }
}
