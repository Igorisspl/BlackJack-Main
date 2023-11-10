using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack_Main
{
    internal class Program
    {
        // Declare variables for game state
        public static int total;
        public static int dealerTotal;
        public static string input;
        public static bool playAgain;

        static void Main(string[] args)
        {
            // Set playAgain to true to enter the game loop
            playAgain = true;

            // Game loop
            while (playAgain)
            {
                // Play a round of the game
                PlayGame();

                // Ask if the player wants to play again
                Console.Write("Do you want another go? (y/n): ");
                input = Console.ReadLine();

                // If the input is not 'y', set playAgain to false to exit the loop
                if (input.ToLower() != "y")
                {
                    playAgain = false;
                }
            }
        }

        // Method to play a round of the game
        static void PlayGame()
        {
            // Initialize and shuffle the deck
            List<Card> deck = InitializeDeck();
            ShuffleDeck(deck);

            // Player's turn
            PlayerTurn(deck);

            // Dealer's turn
            Dealer(deck);

            // Compare results
            CheckResults();
        }

        // Method to initialize a deck of cards
        static List<Card> InitializeDeck()
        {
            List<Card> deck = new List<Card>();

            // Define suits and ranks for the cards
            string[] suits = { "Hearts", "Diamonds", "Clubs", "Spades" };
            string[] ranks = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King", "Ace" };

            // Create cards and add them to the deck
            foreach (var suit in suits)
            {
                foreach (var rank in ranks)
                {
                    int value;
                    if (int.TryParse(rank, out value))
                    {
                        deck.Add(new Card(suit, rank, value));
                    }
                    else
                    {
                        deck.Add(new Card(suit, rank, 10));
                    }
                }
            }
            return deck;
        }

        // Method to shuffle the deck using the Fisher-Yates algorithm
        static void ShuffleDeck(List<Card> deck)
        {
            Random rnd = new Random();
            int n = deck.Count;
            while (n > 1)
            {
                n--;
                int k = rnd.Next(n + 1);
                Card value = deck[k];
                deck[k] = deck[n];
                deck[n] = value;
            }
        }

        // Method for the player's turn
        static void PlayerTurn(List<Card> deck)
        {
            total = 0;

            Console.WriteLine("Player's turn:");

            // Allow the player to draw cards until they choose to stop
            while (total <= 21)
            {
                Card drawnCard = DrawCard(deck);
                Console.WriteLine("Players Card dealt is " + drawnCard);                 //only 1 inital card given due to some bug
                total += drawnCard.Value;
                Console.WriteLine("Total: " + total);

                // Ask if the player wants another card
                Console.Write("Do you want another card? (y/n): ");
                input = Console.ReadLine();

                // If the input is not 'y', exit the loop
                if (input.ToLower() != "y")
                {
                    break;
                }
            }
        }

        // Method for the dealer's turn
        static void Dealer(List<Card> deck)
        {
            dealerTotal = 0;

            Console.WriteLine("\nDealer's turn:");

            // Dealer draws cards until their total is 17 or higher
            while (dealerTotal <= 17)
            {
                Card drawnCard = DrawCard(deck);
                Console.WriteLine("Dealer takes another card " + drawnCard);
                dealerTotal += drawnCard.Value;
            }
        }

        // Method to draw a card from the deck
        static Card DrawCard(List<Card> deck)
        {
            // Check if the deck is empty and reshuffle if needed
            if (deck.Count == 0)
            {
                Console.WriteLine("Out of cards. Reshuffling deck.");
                deck = InitializeDeck();
                ShuffleDeck(deck);
            }

            // Draw the top card from the deck
            Card drawnCard = deck[0];
            deck.RemoveAt(0);
            return drawnCard;
        }

        // Method to compare results and determine the winner
        static void CheckResults()
        {
            Console.WriteLine("\nYour total: " + total);
            Console.WriteLine("Dealer's total: " + dealerTotal);

            // Compare total values to determine the winner or a tie
            if (total == 21)
            {
                Console.WriteLine("BlackJack!");
            }
            else if (dealerTotal == 21)
            {
                Console.WriteLine("BlackJack! (Dealer)");
            }
            else if (dealerTotal > 21)
            {
                Console.WriteLine("Dealer busts");
            }
            else if (total > 21)
            {
                Console.WriteLine("You bust");
            }
            else if (dealerTotal > total)
            {
                Console.WriteLine("Dealer wins");
            }
            else if (total > dealerTotal)
            {
                Console.WriteLine("You win");
            }
            else if (total == dealerTotal)
            {
                Console.WriteLine("It's a tie");
            }
            else { Console.WriteLine(""); }
        }
    }
}
