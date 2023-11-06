using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack_Main
{
    public enum Suit
    {
        Heart,
        Diamond,
        Ace,
        Spade

    }

    public enum Face
    {
        King,
        Queen,
        Jack,
        Ace,
        two,
        three,
        four,
        five,
        six,
        seven,
        eight,
        nine,
        ten
    }
    internal class Cards
    {
        public Suit suit { get; set; }
        public Face face { get; set; }
         public int  Value { get; set; }

         


        
    }
}
