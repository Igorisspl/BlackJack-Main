using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack_Main
{
    // Define a class representing a playing card
    public class Card
    {
        // Properties for the card's suit, rank, and value
        public string Suit { get; }
        public string Rank { get; }
        public int Value { get; }

        // Constructor to initialize the card with suit, rank, and value
        public Card(string suit, string rank, int value)
        {
            Suit = suit;
            Rank = rank;
            Value = value;
        }

        // Override the ToString() method to provide a string representation of the card
        public override string ToString()
        {
            // Format the card as "Rank of Suit"
            return $"{Rank} of {Suit}";
        }
    }
}
