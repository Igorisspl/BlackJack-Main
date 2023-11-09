using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack_Main
{
    internal class Program
    {

        public static int total;
        public static int dealerTotal;
        public static string input;
        public static bool playAgain;
        static void Main(string[] args)
        {

            Random rnd = new Random();

            playAgain = true;

            while (playAgain)
            {
                PlayGame();
                Console.Write("Do you want another go? (y/n): ");
                input = Console.ReadLine();

                if (input.ToLower() != "y")
                {
                    playAgain = false;
                }
            }

        }
        static void PlayGame()
        {
            PlayerTurn();

            Dealer();

            CheckResults();
        }
        static void PlayerTurn()
        {
            Random rnd1 = new Random();
            total = 0;
            while (total <= 21)
            {
                int playerCard = rnd1.Next(1, 12);
                Console.WriteLine("Players Card dealt is " + playerCard);
                int playerCard2 = rnd1.Next(1, 12);
                Console.WriteLine("Players Card dealt is " + playerCard2);
                total = playerCard + playerCard2;
                Console.WriteLine("Total: " + total);

                bool anotherCard = true;

                Console.Write("Do you want another card? (y/n): ");
                input = Console.ReadLine();

                if (input.ToLower() != "y")
                {
                    anotherCard = false;
                }

                while (anotherCard)
                {
                    int player3 = rnd1.Next(1, 12);
                    Console.WriteLine("Player takes another card " + player3);
                    total += player3;
                    Console.WriteLine("Total: " + total);

                    Console.Write("Do you want another card? (y/n): ");
                    input = Console.ReadLine();

                    if (input.ToLower() != "y")
                    {
                        anotherCard = false;
                    }
                }
            }

        }
        static void Dealer()
        {
            Random rnd = new Random();
            int dealer1 = rnd.Next(1, 12);
            int dealer2 = rnd.Next(1, 12);
            dealerTotal = dealer1 + dealer2;
            Console.WriteLine("Dealers card dealt is " + dealer1);
            Console.WriteLine("");
            Console.WriteLine("Dealers card dealt is " + dealer2);
            Console.WriteLine("");

            while (dealerTotal <= 17)
            {
                int dealer3 = rnd.Next(1, 12);
                Console.WriteLine("Dealer takes another card " + dealer3);
                dealerTotal += dealer3;

            }
        }

        //compare
        static void CheckResults()
        {
            Console.WriteLine("Your total: " + total);
            Console.WriteLine("Dealer's total: " + dealerTotal);
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
                Console.WriteLine("Its a tie");
            }
            else { Console.WriteLine(""); }

        }

    }
}
