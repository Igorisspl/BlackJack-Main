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
            
            //get 2 player cards
            Random rnd = new Random();

            playAgain = true;

            while (playAgain)
            {

                //int player1 = rnd.Next(1, 12);
                //int player2 = rnd.Next(1, 12);
                //total = player1 + player2;
                //Console.WriteLine("Players Card dealt is: " + player1);
                //Console.WriteLine("");
                //Console.WriteLine("Players Card dealt is: " + player2);
                //Console.WriteLine("");
                //Console.WriteLine("Total: " + total);
                //Console.WriteLine("");
                PlayerTurn();
                Check();

                //repeat
                bool anotherCard = true;
                Console.Write("Do you want another card? (y/n): ");
                input = Console.ReadLine();

                if (input.ToLower() != "y")
                {
                    anotherCard = false;
                }

                while (anotherCard)
                {
                    int player3 = rnd.Next(1, 12);
                    Console.WriteLine("Players Card dealt is " + player3);
                    total += player3;
                    Console.WriteLine("Total: " + total);
                    Check();

                    Console.Write("Do you want another card? (y/n): ");
                    input = Console.ReadLine();

                    if (input.ToLower() != "y")
                    {
                        anotherCard = false;
                    }
                }

                //dealer section
                int dealer1 = rnd.Next(1, 12);
                int dealer2 = rnd.Next(1, 12);
                dealerTotal = dealer1 + dealer2;
                Console.WriteLine("Dealers card dealt is " + dealer1);
                Console.WriteLine("");
                Console.WriteLine("Dealers card dealt is " + dealer2);
                Console.WriteLine("");
                Console.WriteLine("Dealers total: " + dealerTotal);
                Console.WriteLine("");
                Check();

                while (dealerTotal <= 17)
                {
                    int dealer3 = rnd.Next(1, 12);
                    Console.WriteLine("Dealers Card dealt is " + dealer3);
                    dealerTotal += dealer3;
                    Console.WriteLine("Total: " + dealerTotal);
                    Check();
                }
                CheckResults();
                Console.Write("Do you want another go? (y/n): ");
                input = Console.ReadLine();

                if (input.ToLower() != "y")
                {
                    playAgain = false;
                }
            }

        }
        static void PlayerTurn()
        {
            Random rnd1 = new Random();

            while (total < 21)
            {
                int playerCard = rnd1.Next(1, 12);
                Console.WriteLine("Players Card dealt is " + playerCard);
                int playerCard2 = rnd1.Next(1, 12);
                Console.WriteLine("Players Card dealt is " + playerCard2);
                total = playerCard + playerCard2;
                Console.WriteLine("Total: " + total);

                Console.Write("Do you want another card? (y/n): ");
                input = Console.ReadLine();

                if (input.ToLower() != "y")
                {
                    break;
                }
            }
        }
        static void Check()
        {
            ////compare results
            if (total == 21)
            {
                Console.WriteLine("BlackJack!");
                //Console.Write("Do you want another go? (y/n): ");
                //input = Console.ReadLine();

                //if (input.ToLower() != "y")
                //{
                //    playAgain = false;
                //}
            }
            else if (dealerTotal == 21)
            {
                Console.WriteLine("BlackJack! (Dealer)");
                //Console.Write("Do you want another go? (y/n): ");
                //input = Console.ReadLine();

                //if (input.ToLower() != "y")
                //{
                //    playAgain = false;
                //}
            }
            else if (dealerTotal > 21)
            {
                Console.WriteLine("Dealer busts");
            }
            else if (total > 21)
            {
                Console.WriteLine("You bust");
            }
            else
            {
                Console.WriteLine("");
            }
        }
        static void CheckResults()
        {
            if (dealerTotal > total)
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
        //static void PlayerCard()
        //{
        //    int player1 = rnd.Next(1, 12);
        //}
    }
}
